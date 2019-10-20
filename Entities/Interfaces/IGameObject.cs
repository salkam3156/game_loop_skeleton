using SFML.Graphics;
using SFML.System;

namespace game_loop_skeleton.Entities
{
    public interface IGameObject
    {
        Vector2f GetPosition();
        Vector2f GetDimensions();
        void Move(Vector2f position);
        Sprite Sprite { get; }
    }
}