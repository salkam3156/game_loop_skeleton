using System.Collections.Generic;
using SFML.Graphics;

namespace game_loop_skeleton.Utils.Interfaces
{
    public interface ITextureLoader
    {
        Sprite GetTextureFrom(string bitmap);
    }
}