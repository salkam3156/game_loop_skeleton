using Game.Entities;
using SFML.System;

namespace Game.Systems.Input.Interfaces
{
    public interface ICommand
    {
        Vector2f PointOfAction { get; set; }
        void ExecuteOn(IGameObject gameObject);
    }
}