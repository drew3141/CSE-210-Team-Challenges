﻿using System;
using Raylib_cs;
using Final_Project.Services;
using Final_Project.Interactables;
using Final_Project.Casting;
using Final_Project.Scripting;
using System.Collections.Generic;

namespace Final_Project.GameFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the script
            Dictionary<string, List<Action>> script = new Dictionary<string, List<Action>>();

            OutputService outputService = new OutputService();
            InputService inputService = new InputService();
            PhysicsService physicsService = new PhysicsService();
            AudioService audioService = new AudioService();

            script["output"] = new List<Action>();
            script["input"] = new List<Action>();
            script["update"] = new List<Action>();

            DrawActorsAction drawActorsAction = new DrawActorsAction(outputService);
            script["output"].Add(drawActorsAction);
            MoveActorsAction moveActorsAction = new MoveActorsAction();
            script["update"].Add(moveActorsAction);
            HandleCollisionsAction handleCollisionsAction = new HandleCollisionsAction(new PhysicsService());
            script["update"].Add(handleCollisionsAction);
            ControlActorsAction controlActorsAction = new ControlActorsAction(new InputService(), new PhysicsService());
            script["input"].Add(controlActorsAction);

            // Create the cast
            Dictionary<string, List<Actor>> cast = new Dictionary<string, List<Actor>>();
            Room roomObject = new Room();
            // Add each member to the cast
            cast["room"] = new List<Actor>();
            cast["doors"] = new List<Actor>();
            cast["levers"] = new List<Actor>();
            cast["spikes"] = new List<Actor>();
            foreach (Actor terrain in roomObject.rooms[$"room{controlActorsAction.currentRoom}"])
            {
                cast["room"].Add(terrain);
            }
            foreach (Actor door in roomObject.rooms[$"doors{controlActorsAction.currentRoom}"])
            {
                cast["doors"].Add(door);
            }
            foreach (Actor lever in roomObject.rooms[$"levers{controlActorsAction.currentRoom}"])
            {
                cast["levers"].Add(lever);
            }
            foreach (Actor spike in roomObject.rooms[$"spikes{controlActorsAction.currentRoom}"])
            {
                cast["spikes"].Add(spike);
            }
            cast["player"] = new List<Actor>();
            Player player = new Player();
            cast["player"].Add(player);

            // Start up the game
            outputService.OpenWindow(Constants.MAX_X, Constants.MAX_Y, "The Box", Constants.FRAME_RATE);
            audioService.StartAudio();

            Director theDirector = new Director(cast, script);
            theDirector.Direct();

            audioService.StopAudio();
        }
    }
}
