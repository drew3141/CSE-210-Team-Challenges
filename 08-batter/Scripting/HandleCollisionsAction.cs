using System.Collections.Generic;
using cse210_batter_csharp.Casting;
using cse210_batter_csharp.Services;

namespace cse210_batter_csharp.Scripting
{
    public class HandleCollisionsAction : Action
    {
        PhysicsService _physicsService = new PhysicsService();

        public HandleCollisionsAction(PhysicsService physicsService)
        {
            _physicsService = physicsService;
        }

        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            Actor ball = cast["balls"][0];
            foreach (List<Actor> group in cast.Values)
            {
               foreach (Actor actor in group)
               {
                   
                   if (_physicsService.IsCollision(actor, ball) && actor != ball)
                   {
                        Point flippedVertical = new Point(ball.GetVelocity().GetX(), ball.GetVelocity().GetY()*-1);
                        ball.SetVelocity(flippedVertical);
                   }
               }
            }
            if (ball.GetPosition().GetX() > Constants.MAX_X-ball.GetWidth() | ball.GetPosition().GetX() < ball.GetWidth())   
            {
                Point newV = new Point(ball.GetVelocity().GetX()*-1, ball.GetVelocity().GetY());
                ball.SetVelocity(newV);
            }  
        }

    }
}