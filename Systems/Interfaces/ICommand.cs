using Game.Entities;
using SFML.System;

namespace Game.Systems
{
    public interface ICommand
    {
        Vector2f PointOfAction { get; set; }
        void ExecuteOn(IGameObject gameObject);
    }
}