using System;
using System.Collections.Generic;
using game_loop_skeleton.Utils.Interfaces;
using SFML.Graphics;

namespace game_loop_skeleton.Utils
{
    public class TextureLoader : ITextureLoader
    {
        public IList<Texture> GetTexturesFrom(string bitmap)
        {
            return new List<Texture> { new Texture(@"C:\Users\salka\Desktop\game_loop_skeleton\bin\Debug\netcoreapp2.2\ace.png") };
        }
    }
}