using SFML.Graphics;

namespace Game.Utils
{
    public class ShapeGenerator<T> where T : Shape, new()
    {
        public T GenerateShape()
        {
            return new T();
        }
    }
}