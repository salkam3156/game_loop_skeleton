using System.Collections.Generic;
using SFML.Graphics;

namespace game_loop_skeleton.Utils.Interfaces
{
    public interface IImageLoader
    {
        IEnumerable<Sprite> GetSprites(string spriteSheetPath, int columns, int rows);
        Sprite GetSprite(string spritePath);
    }
}