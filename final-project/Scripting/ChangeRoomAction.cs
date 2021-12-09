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
            if (_inputService.IsDownPressed() && _physicsService.IsCollision(cast["room"][0],cast["player"][0]) /*&& (Door)cast["room"][0].isUnlocked*/)
            {
                currentRoom++;
                cast["room"].Clear();
                foreach (Actor actor in roomObject.rooms[$"room{currentRoom.ToString()}"])
                {
                    cast["room"].Add(actor);
                }
            }
        }
    }
}