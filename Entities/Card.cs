using SFML.Graphics;
using game_loop_skeleton.Utils;
using SFML.System;

namespace game_loop_skeleton.Entities
{
    public class Card : IEntity
    {
        public Sprite Sprite { get; }
        public Card(TextureFlyweight textureFlyweight, /*placeholder for now*/ int deckIndex)
        {
            Sprite = new Sprite(textureFlyweight.Textures[deckIndex]);
        }

        public Vector2f GetPosition()
        {
            return Sprite.Position;
        }

        public void Move(Vector2f position)
        {
            Sprite.Position = position;
        }
    }
}