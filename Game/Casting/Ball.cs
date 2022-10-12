using Trebuchet.Game.Services;
namespace Trebuchet.Game.Casting
{

/// This is the class for the ball object that is in the game
/// The ball will be launched from the trebuchet

    public class Ball : Actor
    {
        private PhysicsService physicsService = new PhysicsService();
        public Ball() {
            this.SetPosition(new Point(100, 100));
            this.SetSprite(new Sprite("Game/Assets/Images/ball.png"));
        }
        
        public void moveBall()
        {
            double v = physicsService.ComputeVelocity(3.0, 10.0, 100.0, 100.0);
            this.SetVelocity(new Point((int)physicsService.ComputeHorizontalComponent(1.5, v), (int)physicsService.ComputeVerticalComponent(1.5, v)));
        }
    }
}
