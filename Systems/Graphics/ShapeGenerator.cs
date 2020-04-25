using SFML.Graphics;

namespace Game.Systems.Graphics
{
    public class ShapeGenerator<T> where T : Shape, new()
    {
        public T GenerateShape()
        {
            return new T();
        }
    }
}