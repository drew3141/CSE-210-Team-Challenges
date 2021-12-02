using System.Collections.Generic;
using Final_Project.Casting;
using Final_Project.Services;

namespace Final_Project.Scripting
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
            Player p = (Player)cast["player"][0];
            foreach (List<Actor> group in cast.Values)
            {
               foreach (Actor actor in group)
               {
                   if (_physicsService.IsCollision(actor, p) && actor != p)
                   {
                       //Horizontal collisions
                    //    if (p.GetLeftEdge() <= actor.GetRightEdge() | p.GetRightEdge() >= actor.GetLeftEdge())
                    //    {
                    //        p.SetVelocity(new Point(0,p.GetVelocity().GetY()));
                    //        if (p.GetLeftEdge() <= actor.GetRightEdge())
                    //        {
                    //            p.SetPosition(new Point(actor.GetPosition().GetX()+actor.GetWidth(),p.GetPosition().GetY()));
                    //        }
                    //        else if (p.GetRightEdge() >= actor.GetLeftEdge())
                    //        {
                    //            p.SetPosition(new Point(actor.GetPosition().GetX(),p.GetPosition().GetY()));
                    //        }
                    //    }
                       //Vertical collisions
                       if (p.GetTopEdge() <= actor.GetBottomEdge() | p.GetBottomEdge() >= actor.GetTopEdge())
                       {
                            p.SetVelocity(new Point(p.GetVelocity().GetX(),0));
                            if (p.GetTopEdge() <= actor.GetBottomEdge())
                            {
                                p.SetPosition(new Point(p.GetPosition().GetX(), actor.GetPosition().GetY()+actor.GetHeight()));
                            }
                            if (p.GetBottomEdge()>= actor.GetTopEdge())
                            {
                                p.CanJump = true;
                                p.SetPosition(new Point(p.GetPosition().GetX(), actor.GetPosition().GetY()-p.GetHeight()));
                            }
                        }
                   }
               }
            }
        }

    }
}