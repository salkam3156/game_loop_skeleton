using SFML.Graphics;

namespace Game.Entities
{
    public class Backgroud
    {
        public Sprite Sprite { get; private set; }

        public Backgroud(string backgroudPicturePath, uint sizeX, uint sizeY)
        {
            Sprite = new Sprite(new Texture(backgroudPicturePath) { Repeated = true })
            {
                TextureRect = new IntRect(0, 0, (int)sizeX, (int)sizeY)
            };
        }
    }
}
