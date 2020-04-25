using Game.Entities;
using Game.Systems.Input.Interfaces;
using SFML.System;

namespace Game.Systems.Input.Commands
{
    public class MouseMoveCommand : ICommand
    {
        public Vector2f PointOfAction { get; set; }

        public void ExecuteOn(IGameObject gameObject)
        {
            gameObject.Move(PointOfAction);
        }
    }
}