using System.Collections.Generic;
using game_loop_skeleton.Utils.Interfaces;
using SFML.Graphics;

namespace game_loop_skeleton.Utils
{
    public class TextureLoader : ITextureLoader
    {
        public IList<Texture> GetTexturesFrom(string spritesheetPath)
        {
            //TODO: walk the spritesheet to build a matrix of images to hold a reference to
            return new List<Texture> { new Texture(spritesheetPath) };
        }
    }
}