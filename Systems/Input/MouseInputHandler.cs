using System.Collections.Generic;
using Game.Entities;
using Game.Systems.Input.Commands;
using Game.Systems.Input.Interfaces;
using SFML.System;
using SFML.Window;

namespace Game.Systems.Input
{
    public class MouseInputHandler : IInputHandler
    {
        private readonly MouseHoverDetector _hoverDetector;
        private readonly IEnumerable<IGameObject> _objects;
        public MouseInputHandler(MouseHoverDetector hoverDetector, IEnumerable<IGameObject> cards)
        {
            _hoverDetector = hoverDetector;
            _objects = cards;
        }
        public ICommand HandleInput()
        {
            ICommand mouseMoveCommand = null;

            if (Mouse.IsButtonPressed(SFML.Window.Mouse.Button.Left))
            {
                foreach (var gameObject in _objects)
                {
                    if (_hoverDetector.IsHoveringOver(gameObject))
                    {
                        //TODO: we already have the value in the detector - refactor
                        var mousePos = Mouse.GetPosition(_hoverDetector.RenderWindow);
                        mouseMoveCommand = new MouseMoveCommand() { PointOfAction = new Vector2f((float)mousePos.X, (float)mousePos.Y) };
                    }
                }
            }

            return mouseMoveCommand;
        }
    }
}