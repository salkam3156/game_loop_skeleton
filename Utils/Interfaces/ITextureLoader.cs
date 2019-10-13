using System.Collections.Generic;
using SFML.Graphics;

namespace game_loop_skeleton.Utils.Interfaces
{
    public interface ITextureLoader
    {
        IList<Texture> GetTexturesFrom(string bitmap);
    }
}