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
                   if (_physicsService.WillCollide(actor, p) && actor != p)
                   {
                        if (p.GetTopEdge()+p.GetVelocity().GetY() < actor.GetBottomEdge())
                        {
                            p.SetVelocity(new Point(p.GetVelocity().GetX(),0));
                            p.SetPosition(new Point(p.GetLeftEdge(), actor.GetBottomEdge()));
                        }
                        else if (p.GetBottomEdge()+p.GetVelocity().GetY() > actor.GetTopEdge())
                        {
                            p.CanJump = true;
                            p.SetVelocity(new Point(p.GetVelocity().GetX(),0));
                            p.SetPosition(new Point(p.GetLeftEdge(), actor.GetTopEdge()-p.GetHeight()));
                        }
                        // else if (p.GetLeftEdge() < actor.GetRightEdge())
                        // {
                        //    p.SetVelocity(new Point(0,p.GetVelocity().GetY()));
                        //    p.SetPosition(new Point(actor.GetPosition().GetX()+actor.GetWidth(),p.GetPosition().GetY()));
                        // }
                        // else if (p.GetRightEdge() > actor.GetLeftEdge())
                        // {
                        //    p.SetVelocity(new Point(0,p.GetVelocity().GetY()));
                        //    p.SetPosition(new Point(actor.GetPosition().GetX(),p.GetPosition().GetY()));
                        // }
                    }
               }
            }
        }

    }
}