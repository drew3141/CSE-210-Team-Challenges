using System.Collections.Generic;
using Final_Project.Casting;

namespace Final_Project.Scripting
{
    public class MoveActorsAction : Action
    {
        public int animationCount = 0;
        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            foreach (List<Actor> group in cast.Values)
            {
               foreach (Actor actor in group)
               {
                   int newX = actor.GetPosition().GetX()+actor.GetVelocity().GetX();
                   int newY = actor.GetPosition().GetY()+actor.GetVelocity().GetY();
                   Point newPosition = new Point(newX, newY);
                   actor.SetPosition(newPosition);
                   Player p = (Player)cast["player"][0];
                   
                   if (p.GetPosition().GetY() > Constants.MAX_Y | p.GetPosition().GetY() < 0 | p.GetPosition().GetX() < 0 | p.GetPosition().GetX() > Constants.MAX_X)
                   {
                       p.isAlive = false;
                   }
                   if (p.GetVelocity().GetX() > 0)
                   {
                       animationCount++;
                       if (animationCount > 24)
                       {
                           animationCount = 0;
                       }
                       switch (animationCount)
                        {
                            case <6:
                                if (p.GravityModifier ==1 )
                                {
                                    p.SetImage("./Assets/PlayerRight1.png");
                                }
                                else {
                                    p.SetImage("./Assets/PlayerRight1Flipped.png");
                                }
                                break;
                            case <12:
                                if (p.GravityModifier ==1 )
                                {
                                    p.SetImage("./Assets/PlayerRight2.png");
                                }
                                else {
                                    p.SetImage("./Assets/PlayerRight2Flipped.png");
                                }
                                break;
                            case <18:
                                if (p.GravityModifier ==1 )
                                {
                                    p.SetImage("./Assets/PlayerRight3.png");
                                }
                                else {
                                    p.SetImage("./Assets/PlayerRight3Flipped.png");
                                }
                                break;
                            case <24:
                                if (p.GravityModifier ==1 )
                                {
                                    p.SetImage("./Assets/PlayerRight4.png");
                                }
                                else {
                                    p.SetImage("./Assets/PlayerRight4Flipped.png");
                                }
                                break;
                        }
                   }
                   else if (p.GetVelocity().GetX() < 0)
                   {
                       animationCount++;
                       if (animationCount > 24)
                       {
                           animationCount = 0;
                       }
                       switch (animationCount%6)
                        {
                            case <6:
                                if (p.GravityModifier ==1 )
                                {
                                    p.SetImage("./Assets/PlayerLeft1.png");
                                }
                                else {
                                    p.SetImage("./Assets/PlayerLeft1Flipped.png");
                                }
                                break;
                            case <12:
                                if (p.GravityModifier ==1 )
                                {
                                    p.SetImage("./Assets/PlayerLeft2.png");
                                }
                                else {
                                    p.SetImage("./Assets/PlayerLeft2Flipped.png");
                                }
                                break;
                            case <18:
                                if (p.GravityModifier ==1 )
                                {
                                    p.SetImage("./Assets/PlayerLeft3.png");
                                }
                                else {
                                    p.SetImage("./Assets/PlayerLeft3Flipped.png");
                                }
                                break;
                            case <24:
                                if (p.GravityModifier ==1 )
                                {
                                    p.SetImage("./Assets/PlayerLeft4.png");
                                }
                                else {
                                    p.SetImage("./Assets/PlayerLeft4Flipped.png");
                                }
                                break;
                        }
                   }
                   else if (p.GetVelocity().GetX() == 0)
                   {
                       animationCount = 0;
                   }
               }
            }
        }
    }
}