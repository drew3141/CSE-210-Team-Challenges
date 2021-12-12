using System.Collections.Generic;
using Final_Project.Casting;
using Final_Project.Services;
using Final_Project.Interactables;
using Final_Project.GameFlow;
using System;

namespace Final_Project.Scripting
{
    public class ControlActorsAction : Action
    {
        InputService _inputService = new InputService();
        PhysicsService _physicsService = new PhysicsService();
        public int currentRoom = 1;
        Room roomObject = new Room();
        Random r = new Random();

        public ControlActorsAction(InputService inputService, PhysicsService physicsService)
        {
            _inputService = inputService;
            _physicsService = physicsService;
            
        }

        public void MoveNextRoom(Dictionary<string, List<Actor>> cast)
        {
            roomObject = new Room();
            cast["room"].Clear();
            cast["doors"].Clear();
            cast["levers"].Clear();
            cast["spikes"].Clear();
            foreach (Actor actor in roomObject.rooms[$"room{currentRoom}"])
            {
                cast["room"].Add(actor);
            }
            foreach (Actor door in roomObject.rooms[$"doors{currentRoom}"])
            {
                cast["doors"].Add(door);
            }
            foreach (Actor lever in roomObject.rooms[$"levers{currentRoom}"])
            {
                cast["levers"].Add(lever);
            }
            foreach (Actor spike in roomObject.rooms[$"spikes{currentRoom}"])
            {
                cast["spikes"].Add(spike);
            }
        }
        
        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            Player p = (Player)cast["player"][0];
            Door d = (Door)cast["doors"][0];
            //Gravity movement
            p.SetVelocity(new Point(p.GetVelocity().GetX(),p.GetVelocity().GetY()+p.GravityModifier));
            //User input for left/right
            Point direction = _inputService.GetDirection();
            direction = new Point(direction.GetX()*6,p.GetVelocity().GetY());
            p.Move(direction);
            //Lever Delay so it doesn't keep flipping
            foreach (Lever lever in cast["levers"])
            {
                if (lever.delay > 0)
                {
                    lever.delay--;
                }
            }
            //Jump input
            if (_inputService.IsUpPressed())
            {
                p.Jump();
                p.waitingToRelease = true;
            }
            else
            {
                p.waitingToRelease = false;
            }
            //Interacting with objects input
            if (_inputService.IsDownPressed())
            {
                //Handle Moving Through Doors
                if (_physicsService.IsCollision(d,p) && d.isUnlocked)
                {
                    currentRoom++;
                    switch (currentRoom)
                    {
                        case 1:
                            p.SetPosition(new Point(Constants.MAX_X/2,Constants.MAX_Y-Constants.TERRAIN_HEIGHT-Constants.PLAYER_HEIGHT-200));
                            break;
                        case 2:
                            p.SetPosition(new Point(Constants.MAX_X/2, Constants.MAX_Y-200));
                            break;
                        case 3:
                            p.SetPosition(new Point(120, Constants.MAX_Y-200));
                            break;
                        case 4:
                            p.SetPosition(new Point(200, Constants.MAX_Y-200));
                            break;
                        case 5:
                            p.SetPosition(new Point(Constants.MAX_X/2, Constants.MAX_Y-200));
                            p.GravityModifier = 1;
                            break;
                        case 6:
                            p.SetPosition(new Point(200, Constants.MAX_Y-200));
                            p.GravityModifier = 1;
                            break;
                        case 7:
                            p.SetPosition(new Point(200, Constants.MAX_Y-200));
                            break;
                        default:
                            //Say something about the game being over
                            break;
                    }
                    MoveNextRoom(cast);
                }
                //Handle using levers
                foreach (Lever lever in cast["levers"])
                {
                    if (_physicsService.IsCollision(p, lever) && lever.delay == 0)
                    {
                        if (lever.powerOn)
                        {
                            lever.flipState();
                            lever.delay+=10;
                            switch (currentRoom)
                            {
                                case 2:
                                    d.lockDoor();
                                    break;
                                case 3:
                                    d.lockDoor();
                                    break;
                                case 4:
                                    p.GravityModifier*= -1;
                                    break;
                                case 5:
                                    p.GravityModifier*= -1;
                                    break;
                                case 6:
                                    foreach (Terrain t in cast["room"])
                                    {
                                        t.SetPosition(new Point(r.Next(0, Constants.MAX_X-40), r.Next(0, Constants.MAX_Y-40)));
                                    }
                                    cast["room"][10].SetPosition(new Point(80,Constants.MAX_Y-Constants.TERRAIN_HEIGHT));
                                    cast["room"][11].SetPosition(new Point(120,Constants.MAX_Y-Constants.TERRAIN_HEIGHT));
                                    cast["room"][12].SetPosition(new Point(160,Constants.MAX_Y-Constants.TERRAIN_HEIGHT));
                                    break;
                                case 7:
                                    break;
                                
                            }
                        }
                        else 
                        {
                            lever.flipState();
                            lever.delay+=10;
                            switch (currentRoom)
                            {
                                case 2:
                                    d.unlockDoor();
                                    break;
                                case 3:
                                    d.unlockDoor();
                                    break;
                                case 4:
                                    p.GravityModifier*= -1;
                                    break;
                                case 5:
                                    p.GravityModifier*= -1;
                                    break;
                                case 6:
                                    foreach (Terrain t in cast["room"])
                                    {
                                        t.SetPosition(new Point(r.Next(0, Constants.MAX_X-40), r.Next(0, Constants.MAX_Y-40)));
                                    }
                                    cast["room"][10].SetPosition(new Point(80,Constants.MAX_Y-Constants.TERRAIN_HEIGHT));
                                    cast["room"][11].SetPosition(new Point(120,Constants.MAX_Y-Constants.TERRAIN_HEIGHT));
                                    cast["room"][12].SetPosition(new Point(160,Constants.MAX_Y-Constants.TERRAIN_HEIGHT));
                                    break;
                                case 7:
                                    Actor winScreen = new Actor();
                                    winScreen.SetImage("./Assets/WinScreen.png");
                                    winScreen.SetPosition(new Point(Constants.MAX_X/2-200, Constants.MAX_Y/2-80));
                                    cast["room"].Add(winScreen);
                                    break;
                                
                            }
                        }
                    }
                }
                
            }
        }
    }
}