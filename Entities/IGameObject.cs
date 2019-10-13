using SFML.System;

namespace game_loop_skeleton.Entities
{
    public interface IGameObject
    {
        Vector2f GetPosition();
        void Move(Vector2f position);
    }
}