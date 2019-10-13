namespace game_loop_skeleton.Systems
{
    public interface IInputHandler
    {
        //TODO: consider an interface for the input device to inject into the ctor ? 
        void HandleInput();
    }
}