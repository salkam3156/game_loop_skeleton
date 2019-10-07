using SFML.Graphics;
using game_loop_skeleton.Utils;

namespace game_loop_skeleton.Entities
{
    public class Card
    {
        private readonly Texture _texture;
        public Card(TextureFlyweight textureFlyweight, /*placeholder for now*/ int deckIndex)
        {
            _texture = textureFlyweight.Textures[deckIndex];
        }
    }
}