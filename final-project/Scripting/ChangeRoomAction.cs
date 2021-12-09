using System.Collections.Generic;
using Final_Project.Casting;
using Final_Project.Services;
using Final_Project.Interactables;
using Final_Project.GameFlow;
using System;

namespace Final_Project.Scripting
{
    public class ChangeRoomAction : Action
    {
        InputService _inputService = new InputService();
        PhysicsService _physicsService = new PhysicsService();
        public int currentRoom = 1;
        Room roomObject = new Room();

        public ChangeRoomAction(PhysicsService physicsService)
        {
            _physicsService= physicsService;
            roomObject = new Room();
        }
        
        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            Player p = (Player)cast["player"][0];
            if (_inputService.IsDownPressed() && _physicsService.IsCollision(cast["room"][0],cast["player"][0]) /*&& (Door)cast["room"][0].isUnlocked*/)
            {
                currentRoom++;
                switch (currentRoom)
                {
                    case 1:
                        //Do stuff
                        break;
                    case 2:
                        //Do Stuff
                        break;
                    case 3:
                        //Do Stuff
                        break;
                    case 4:
                        p.GravityModifier = -1;
                        break;
                    default:
                        //Say something about the game being over
                        break;
                }
                cast["room"].Clear();
                foreach (Actor actor in roomObject.rooms[$"room{currentRoom.ToString()}"])
                {
                    cast["room"].Add(actor);
                }
                    
            }
        }
    }
}