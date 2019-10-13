using System;
using System.Collections.Generic;
using System.IO;
using game_loop_skeleton.Utils.Interfaces;
using SFML.Graphics;

namespace game_loop_skeleton.Utils
{
    public class TextureFlyweight
    {
        public IList<Texture> Textures { get; private set; } = new List<Texture>();
        private readonly ITextureLoader _textureLoader;
        public readonly string _spriteSheetPath;

        //TODO: refactor after TextureLoader has been implemented
        public TextureFlyweight(string spriteSheetPath, ITextureLoader textureLoader)
        {
            _spriteSheetPath = spriteSheetPath;
            _textureLoader = textureLoader;
        }

        public void Initialize()
        {
            Textures = _textureLoader?.GetTexturesFrom(_spriteSheetPath);
        }

    }
}