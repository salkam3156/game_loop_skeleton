using System.Collections.Generic;
using game_loop_skeleton.Entities;
using SFML.System;
using SFML.Window;
using static SFML.Window.Mouse;

namespace game_loop_skeleton.Systems
{
    public class MouseInputHandler : IInputHandler
    {
        private readonly MouseHoverDetector _hoverDetector;
        private readonly IList<IGameObject> _cards;
        public MouseInputHandler(MouseHoverDetector hoverDetector, IList<IGameObject> cards)
        {
            _hoverDetector = hoverDetector;
            _cards = cards;
        }
        public ICommand HandleInput()
        {
            ICommand mouseMoveCommand = null;

            if (Mouse.IsButtonPressed(Button.Left))
            {
                foreach (var card in _cards)
                {
                    if (_hoverDetector.IsHoveringOver(card))
                    {
                        //TODO: we already have the value in the detector - refactor
                        var mousePos = Mouse.GetPosition();
                        mouseMoveCommand = new MouseMoveCommand() { PointOfAction = new Vector2f((float)mousePos.X, (float)mousePos.Y) };
                    }
                }
            }

            return mouseMoveCommand;
        }
    }
}