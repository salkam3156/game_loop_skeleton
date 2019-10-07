using SFML.Graphics;
using game_loop_skeleton.Utils;

namespace game_loop_skeleton.Entities
{
    public class Card
    {
        private Sprite Sprite { get; }
        public Card(TextureFlyweight textureFlyweight, /*placeholder for now*/ int deckIndex)
        {
            Sprite = new Sprite(textureFlyweight.Textures[deckIndex]);
        }
    }
}