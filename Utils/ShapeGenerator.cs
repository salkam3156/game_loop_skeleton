using SFML.Graphics;

namespace SFML_Lechu.Utils
{
    public class ShapeGenerator<T> where T : Shape, new()
    {
        public T GenerateShape()
        {
            return new T();
        }
    }
}