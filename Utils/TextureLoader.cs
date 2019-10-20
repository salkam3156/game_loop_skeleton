using System.Collections.Generic;
using game_loop_skeleton.Utils.Interfaces;
using SFML.Graphics;

namespace game_loop_skeleton.Utils
{
    public class TextureLoader : ISpriteLoader
    {
        public IList<Sprite> GetSpritesFrom(string spritesheetPath, int columns, int rows)
        {
            //TODO: walk the spritesheet to build a matrix of images to hold a reference to
            return new List<Sprite> { new Sprite(spritesheetPath) };
        }
    }
}