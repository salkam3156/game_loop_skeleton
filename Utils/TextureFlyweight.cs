using System.Collections.Generic;
using game_loop_skeleton.Utils.Interfaces;
using SFML.Graphics;

namespace game_loop_skeleton.Utils
{
    public class TextureFlyweight
    {
        public IEnumerable<Sprite> Textures { get; private set; } = new List<Sprite>();
        private readonly ISpriteSheetLoader _imageLoader;
        public TextureFlyweight(ISpriteSheetLoader spriteSheetLoader)
        {
            _imageLoader = spriteSheetLoader;
        }
        public void Initialize()
        {
            Textures = _imageLoader?.GetSprites();
        }

    }
}