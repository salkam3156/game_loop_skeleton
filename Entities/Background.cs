using System;
using System.Collections.Generic;
using System.IO;
using game_loop_skeleton.Utils.Interfaces;
using SFML.Graphics;

namespace game_loop_skeleton.Utils
{
    public class Backgroud
    {
        public Sprite Sprite { get; private set; }

        public Backgroud(string backgroudPicturePath, uint sizeX, uint sizeY)
        {
            Sprite = new Sprite(new Texture(backgroudPicturePath) { Repeated = true })
            {
                TextureRect = new IntRect(0, 0, (int) sizeX, (int) sizeY)
            };
        }
    }
}
