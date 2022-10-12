using Trebuchet.Game.Casting;
using Trebuchet.Game.Services;

namespace Trebuchet.Game.Scripting 
{
    /// The responsibility of action is to do something that is integral or important in the game. 
    /// Thus, it has one method, Execute(...), which should be overridden by derived classes.
    public class DrawActors : Action
    {
        private VideoService videoService;
        public DrawActors(VideoService videoService)
        {
            this.videoService = videoService;
        }
        public void Execute(Cast cast, Script script)
        {
            videoService.DrawActors(cast.GetAllActors());
            videoService.ClearBuffer();
        }
    }
}