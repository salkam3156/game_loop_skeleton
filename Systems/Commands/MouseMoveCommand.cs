using game_loop_skeleton.Entities;
using SFML.System;

namespace game_loop_skeleton.Systems
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