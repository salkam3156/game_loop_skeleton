using System.Collections.Generic;
using SFML.Graphics;

namespace Game.Utils.Interfaces
{
    public interface IImageLoader
    {
        IEnumerable<Sprite> GetSprites(string spriteSheetPath, int columns, int rows);
        Sprite GetSprite(string spritePath);
    }
}