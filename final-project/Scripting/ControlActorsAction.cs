using System.Collections.Generic;
using Final_Project.Casting;
using Final_Project.Services;

namespace Final_Project.Scripting
{
    public class ControlActorsAction : Action
    {
        InputService _inputService = new InputService();

        public ControlActorsAction(InputService inputService)
        {
            _inputService = inputService;
        }
        
        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            Player p = (Player)cast["player"][0];
            Point direction = _inputService.GetDirection();
            if (p.GetPosition().GetY() < Constants.MAX_Y-(Constants.PLAYER_HEIGHT+Constants.TERRAIN_HEIGHT))
            {
                p.SetVelocity(new Point(p.GetVelocity().GetX(),p.GetVelocity().GetY()+p.GravityModifier));
            }
            if (_inputService.IsUpPressed() && p.CanJump)
            {
                p.Jump();
            }
            if (_inputService.IsDownPressed())
            {
                p.OpenDoor();
            }
            direction = new Point(direction.GetX()*6,p.GetVelocity().GetY());
            p.SetVelocity(direction);
            
        }
    }
}