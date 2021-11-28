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
            Point direction = _inputService.GetDirection();
            direction = new Point(direction.GetX()*7,direction.GetY()*7);
        }
    }
}