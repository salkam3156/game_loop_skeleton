using game_loop_skeleton.Entities;
using SFML.Window;

namespace game_loop_skeleton.Systems
{
    public class MouseHoverDetector
    {
        //TODO: A POC; this will be inefficient for now
        //TODO: check behaviour on scaled screen dims - the values for texture dimensions might not scale to the skew applied
        public bool IsHoveringOver(IGameObject gameObject)
        {
            var mousePos = Mouse.GetPosition();
            var gameObjPos = gameObject.GetPosition();
            var gameObjDims = gameObject.GetDimensions();

            return (mousePos.X > gameObjPos.X && mousePos.X < gameObjPos.X + gameObjDims.X)
                && (mousePos.Y > gameObjPos.Y && mousePos.Y < gameObjPos.Y + gameObjDims.Y);
        }
    }
}