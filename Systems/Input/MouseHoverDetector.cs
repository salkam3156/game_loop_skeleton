using Game.Entities;
using SFML.Graphics;
using SFML.Window;

namespace Game.Systems.Input
{
    public class MouseHoverDetector
    {
        //TODO: A POC; this will be inefficient for now
        //TODO: check behaviour on scaled screen dims - the values for texture dimensions might not scale to the skew applied
        public RenderWindow RenderWindow { get; private set; }

        public MouseHoverDetector(RenderWindow renderWindow)
        {
            RenderWindow = renderWindow;
        }
        public bool IsHoveringOver(IGameObject gameObject)
        {
            var mousePos = Mouse.GetPosition(RenderWindow);
            var gameObjPos = gameObject.GetPosition();
            var gameObjDims = gameObject.GetDimensions();

            return (mousePos.X > gameObjPos.X && mousePos.X < gameObjPos.X + gameObjDims.X)
                && (mousePos.Y > gameObjPos.Y && mousePos.Y < gameObjPos.Y + gameObjDims.Y);
        }
    }
}