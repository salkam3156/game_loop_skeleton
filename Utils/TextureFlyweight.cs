using System.Collections.Generic;
using game_loop_skeleton.Utils.Interfaces;
using SFML.Graphics;

namespace game_loop_skeleton.Utils
{
    public class TextureFlyweight
    {
        public IEnumerable<Sprite> Textures { get; private set; } = new List<Sprite>();
        private readonly IImageLoader _imageLoader;
        public TextureFlyweight(IImageLoader textureLoader)
        {
            _imageLoader = textureLoader;
        }
        public void Initialize()
        {
            Textures = _imageLoader?.GetSprites();
        }

    }
}