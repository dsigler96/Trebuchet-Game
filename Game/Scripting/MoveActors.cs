using Trebuchet.Game.Casting;


namespace Trebuchet.Game.Scripting 
{
    /// The responsibility of action is to do something that is integral or important in the game. 
    /// Thus, it has one method, Execute(...), which should be overridden by derived classes.
    public class MoveActors : Action
    {
        public void Execute(Cast cast, Script script)
        {
            Ball ball = (Ball)cast.GetActors("ball")[0];
            ball.moveBall();
        }
    }
}