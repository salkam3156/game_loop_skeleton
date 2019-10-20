using SFML.Graphics;
using game_loop_skeleton.Utils;
using SFML.System;

namespace game_loop_skeleton.Entities
{
    public class Card : IGameObject
    {
        public Sprite Sprite { get; }
        public Card(TextureFlyweight textureFlyweight, /*placeholder for now*/ int deckIndex)
        {
            var texiter = textureFlyweight.Textures.GetEnumerator();
            texiter.MoveNext();
            Sprite = new Sprite(texiter.Current);
        }

        public Vector2f GetPosition()
        {
            return Sprite.Position;
        }
        public Vector2f GetDimensions()
        {
            return new Vector2f(Sprite.TextureRect.Width, Sprite.TextureRect.Height);
        }

        public void Move(Vector2f position)
        {
            Sprite.Position = new Vector2f(position.X - Sprite.TextureRect.Width / 2, position.Y - Sprite.TextureRect.Height / 2);
        }

    }
}