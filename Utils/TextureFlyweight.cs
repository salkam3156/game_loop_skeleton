using System.Collections.Generic;
using System.IO;
using SFML.Graphics;

namespace game_loop_skeleton.Utils
{
    public class TextureFlyweight
    {
        public IList<Texture> Textures { get; } = new List<Texture>();
        public readonly string _spriteSheetPath;

        //TODO: refactor after TextureLoader has been implemented
        public TextureFlyweight(string spriteSheetPath)
        {
            _spriteSheetPath = spriteSheetPath;


        }

    }
}