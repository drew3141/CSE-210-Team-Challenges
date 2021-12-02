using System.Collections.Generic;
using Final_Project.Casting;

namespace Final_Project.Scripting
{
    public class MoveActorsAction : Action
    {
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
               }
            }
        }
    }
}