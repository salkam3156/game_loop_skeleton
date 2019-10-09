using System.Collections.Generic;
using SFML.Graphics;
using SFML_Lechu.App;
using SFML.System;
using game_loop_skeleton.Utils;
using System;



namespace game_loop_skeleton.Utils
{
    public class PositionGenerator
    {
        public uint SizeX;
        public uint SizeY;
        public float Frequency;
        public float Scale;
        public Vector2f GetPositionByWindowVector(int currentX)
        {
           float floatX = (float) currentX;
           return new Vector2f(currentX, (float) Math.Abs(Math.Cos(floatX/Scale) * Frequency * SizeY / floatX));
        }
    }
}