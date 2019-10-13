using System.Collections.Generic;
using game_loop_skeleton.Utils.Interfaces;
using SFML.Graphics;

namespace game_loop_skeleton.Utils
{
    public class BackgroundTextureLoader : ITextureLoader
    {
        private readonly uint _sizeX;
        private readonly uint _sizeY;

        public BackgroundTextureLoader( uint sizeX, uint sizeY)
        {
            _sizeX = sizeX;
            _sizeY = sizeY; 
        }

        public Sprite GetTextureFrom(string bitmap)
        {
            return new Sprite(new Texture(bitmap) { Repeated = true })
            {
                TextureRect = new IntRect(0, 0, (int)_sizeX, (int)_sizeY)
            };
        }
    }
}