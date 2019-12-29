using System.Collections.Generic;
using System.IO;
using Game.Utils.Interfaces;
using SFML.Graphics;

namespace Game.Utils
{
    public class TextureLoader : IImageLoader
    {
        public IEnumerable<Sprite> GetSprites(string spriteSheetPath, int columns, int rows)
        {
            if (!File.Exists(spriteSheetPath)) throw new FileNotFoundException($"The file {spriteSheetPath} does not exist");

            var spriteSheet = new Texture(spriteSheetPath);
            var columnWidth = (int)spriteSheet.Size.X / columns;
            var rowHeight = (int)spriteSheet.Size.Y / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    yield return new Sprite(spriteSheet, new IntRect(
                        (j * columnWidth), (i * rowHeight),
                        (j + 1 * columnWidth), (i + 1 * rowHeight)
                    ));
                }
            }
        }

        public Sprite GetSprite(string spritePath)
        {
            return new Sprite(new Texture(spritePath));
        }
    }
}