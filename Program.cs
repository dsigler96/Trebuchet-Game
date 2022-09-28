using Trebuchet.Game.Casting;
using Trebuchet.Game.Directing;
using Trebuchet.Game.Scripting;
using Trebuchet.Game.Services;
using Trebuchet.Game;


namespace Trebuchet
{
    /// The program's entry point.
    class Program
    {
        /// Starts the program using the given arguments.
        static void Main(string[] args)
        {
            // create the services
            // KeyboardService keyboardService = new KeyboardService();
            
            VideoService videoService = new VideoService(false);
            AudioService audioService = new AudioService();

            // create the cast
            Cast cast = new Cast();
            
            // initialize audio
            audioService.Initialize();
            audioService.LoadSounds("Game/Assets/Sounds");
            audioService.LoadMusic("Game/Assets/Music");

            // create the script to be run each frame
            Script script = new Script();
            script.AddAction("output", new DrawTitle(videoService, gamepadService, audioService, Constants.STARTMESSAGE));

            // start the game
            Director director = new Director(videoService);
            director.StartGame(cast, script);
        }
    }
}