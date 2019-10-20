using System.Collections.Generic;
using game_loop_skeleton.Utils.Interfaces;
using SFML.Graphics;

namespace game_loop_skeleton.Utils
{
    public class TextureLoader : IImageLoader
    {
        private readonly string _spriteSheetPath = string.Empty;
        private readonly int _columns;
        private readonly int _rows;
        public TextureLoader(string spritesheetPath, int columns, int rows)
        {
            _spriteSheetPath = spritesheetPath;
            _columns = columns;
            _rows = rows;
        }
        public IEnumerable<Sprite> GetSprites()
        {
            var spriteSheet = new Texture(_spriteSheetPath);
            var columnWidth = (int)spriteSheet.Size.X / _columns;
            var rowHeight = (int)spriteSheet.Size.Y / _rows;

            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _columns; j++)
                {
                    yield return new Sprite(spriteSheet, new IntRect(
                        (j * columnWidth), (i * rowHeight),
                        (j + 1 * columnWidth), (i + 1 * rowHeight)
                    ));
                }
            }
        }
    }
}