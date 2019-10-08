using System;
using System.Collections.Generic;
using game_loop_skeleton.Utils.Interfaces;
using SFML.Graphics;

namespace game_loop_skeleton.Utils
{
    public class TextureLoader : ITextureLoader
    {
        public IList<Texture> GetTexturesFrom(string spritesheetPath)
        {
            return new List<Texture> { new Texture(spritesheetPath) };
        }
    }
}