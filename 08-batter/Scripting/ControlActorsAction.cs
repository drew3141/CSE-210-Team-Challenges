using System.Collections.Generic;
using cse210_batter_csharp.Casting;
using cse210_batter_csharp.Services;

namespace cse210_batter_csharp.Scripting
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
            
        }
    }
}