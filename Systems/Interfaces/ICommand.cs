using game_loop_skeleton.Entities;
using SFML.System;

namespace game_loop_skeleton.Systems
{
    public interface ICommand
    {
        Vector2f PointOfAction { get; set; }
        void ExecuteOn(IGameObject gameObject);
    }
}