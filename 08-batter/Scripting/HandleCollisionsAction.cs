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
            Ball ball = (Ball)cast["balls"][0];
            List<Actor> toRemove = new List<Actor>();
            foreach (List<Actor> group in cast.Values)
            {
               foreach (Actor actor in group)
               {
                   if (_physicsService.IsCollision(actor, ball) && actor != ball)
                   {
                        _audioService.PlaySound(Constants.SOUND_BOUNCE);
                        ball.flipVertical();
                        if (group == cast["bricks"])
                        {
                            Brick b = (Brick)actor;
                            b.ReduceTier();
                            if (!b.IsAlive())
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
                ball.flipHorizontal();
            }
        }

    }
}