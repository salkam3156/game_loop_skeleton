namespace game_loop_skeleton.Systems
{
    public class UpdateTimeModel
    {
        public double FrameTime { get; set; } = 1000 / 60F;
        public double LogicUpdateTime { get; set; } = 1000 / 120F;
    }
}