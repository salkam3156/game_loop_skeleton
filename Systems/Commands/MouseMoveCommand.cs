using Game.Entities;
using SFML.System;

namespace Game.Systems
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