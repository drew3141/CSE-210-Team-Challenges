using System.Collections.Generic;
using cse210_batter_csharp.Casting;
using cse210_batter_csharp.Services;

namespace cse210_batter_csharp.Scripting
{
    public class HandleCollisionsAction : Action
    {
        PhysicsService _physicsService = new PhysicsService();
        AudioService _audioService = new AudioService();

        public HandleCollisionsAction(PhysicsService physicsService)
        {
            _physicsService = physicsService;
        }

        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            Actor ball = cast["balls"][0];
            List<Actor> toRemove = new List<Actor>();
            foreach (List<Actor> group in cast.Values)
            {
               foreach (Actor actor in group)
               {
                   if (_physicsService.IsCollision(actor, ball) && actor != ball)
                   {
                        _audioService.PlaySound(Constants.SOUND_BOUNCE);
                        Point flippedVertical = new Point(ball.GetVelocity().GetX(), ball.GetVelocity().GetY()*-1);
                        ball.SetVelocity(flippedVertical);
                        if (group == cast["bricks"])
                        {
                            //ReduceTier of brick and check isAlive 
                            bool aliveCondition = true;
                            if (aliveCondition)
                            {
                                toRemove.Add(actor);
                            }
                        }
                   }
               }
            }
            foreach(Actor actor in toRemove)
            {
                cast["bricks"].Remove(actor);
            }
            if (ball.GetPosition().GetX() > Constants.MAX_X-ball.GetWidth() | ball.GetPosition().GetX() < ball.GetWidth())   
            {
                _audioService.PlaySound(Constants.SOUND_BOUNCE);
                Point newV = new Point(ball.GetVelocity().GetX()*-1, ball.GetVelocity().GetY());
                ball.SetVelocity(newV);
            }
        }

    }
}