using System.Collections.Generic;
using game_loop_skeleton.Utils.Interfaces;
using SFML.Graphics;

namespace game_loop_skeleton.Utils
{
    public class TextureFlyweight
    {
        public IList<Sprite> Textures { get; private set; } = new List<Sprite>();
        private readonly ISpriteLoader _textureLoader;
        public readonly string _spriteSheetPath;

        //TODO: refactor after TextureLoader has been implemented
        public TextureFlyweight(string spriteSheetPath, ISpriteLoader textureLoader)
        {
            _spriteSheetPath = spriteSheetPath;
            _textureLoader = textureLoader;
        }

        public void Initialize()
        {
            Textures = _textureLoader?.GetSpritesFrom(_spriteSheetPath);
        }

    }
}