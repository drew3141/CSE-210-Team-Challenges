using System;
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
            // Create the cast
            Dictionary<string, List<Actor>> cast = new Dictionary<string, List<Actor>>();
            // Add each member to the cast
            cast["terrain"] = new List<Actor>();
            for (int i = 0; i < Constants.MAX_Y/Constants.TERRAIN_HEIGHT;i++)
            {
                Terrain terrain = new Terrain(0,i*Constants.TERRAIN_HEIGHT);
                cast["terrain"].Add(terrain);
            }
            for (int i = 0; i < Constants.MAX_Y/Constants.TERRAIN_HEIGHT;i++)
            {
                Terrain terrain = new Terrain(Constants.MAX_X-Constants.TERRAIN_WIDTH,i*Constants.TERRAIN_HEIGHT);
                cast["terrain"].Add(terrain);
            }
            for (int i = 0; i < Constants.MAX_X/Constants.TERRAIN_WIDTH;i++)
            {
                Terrain terrain = new Terrain(i*Constants.TERRAIN_WIDTH,Constants.MAX_Y-Constants.TERRAIN_HEIGHT);
                cast["terrain"].Add(terrain);
            }
            for (int i = 0; i < 10;i++)
            {
                Terrain terrain = new Terrain(i*Constants.TERRAIN_WIDTH,700);
                cast["terrain"].Add(terrain);
            }
            cast["player"] = new List<Actor>();
            Player player = new Player();
            cast["player"].Add(player);

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
            ControlActorsAction controlActorsAction = new ControlActorsAction(new InputService());
            script["input"].Add(controlActorsAction);


            // TODO: Add additional actions here to handle the input, move the actors, handle collisions, etc.

            // Start up the game
            outputService.OpenWindow(Constants.MAX_X, Constants.MAX_Y, "The Box", Constants.FRAME_RATE);
            audioService.StartAudio();

            Director theDirector = new Director(cast, script);
            theDirector.Direct();

            audioService.StopAudio();
        }
    }
}
