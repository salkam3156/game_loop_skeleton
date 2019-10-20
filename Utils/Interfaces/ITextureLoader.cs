using System.Collections.Generic;
using SFML.Graphics;

namespace game_loop_skeleton.Utils.Interfaces
{
    public interface ISpriteLoader
    {
        IList<Sprite> GetSpritesFrom(string bitmap, int columns, int rows);
    }
}