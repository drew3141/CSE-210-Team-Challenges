using System.Collections.Generic;
using Final_Project.Casting;
using Final_Project.Services;
using Final_Project.Interactables;
using System;

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
                    if (_physicsService.IsCollision(actor, p) && group == cast["spikes"])
                    {
                        p.isAlive = false;
                    }
                    if (_physicsService.IsCollision(actor, p) && group == cast["room"])
                    {
                        if (p.GetVelocity().GetY()*p.GravityModifier>30)
                        {
                            p.isAlive = false;
                        }
                        Point overlap = _physicsService.GetCollisionOverlap(actor, p);
                        if (Math.Abs(overlap.GetX()) < Math.Abs(overlap.GetY()))
                        {
                            // Depth was least along the x-axis, so that's our point of collision
                            if (overlap.GetX() > 0)
                            {
                                // Collision on the left
                                p.SetVelocity(new Point(0, p.GetVelocity().GetY()));
                                p.SetLeftEdge(actor.GetRightEdge());
                            }
                            else
                            {
                                // Collision on the right
                                p.SetVelocity(new Point(0, p.GetVelocity().GetY()));
                                p.SetRightEdge(actor.GetLeftEdge());
                            }
                        }
                        else
                        {
                            // Collision on the y-axis
                            if (overlap.GetY() > 0)
                            {
                                // Collision on the top
                                p.SetVelocity(new Point(p.GetVelocity().GetX(), 0));
                                p.SetTopEdge(actor.GetBottomEdge());
                                if (p.GravityModifier <0)
                                {
                                    p.CanJump = true;
                                }
                            }
                            else
                            {
                                // Collision on the bottom
                                p.SetVelocity(new Point(p.GetVelocity().GetX(), 0));
                                p.SetBottomEdge(actor.GetTopEdge());
                                if(p.GravityModifier>0)
                                {
                                    p.CanJump = true;
                                }
                            }
                        }
                        
                    }
               }
            }
        }

    }
}