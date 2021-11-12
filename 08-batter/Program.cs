using System;
using cse210_batter_csharp.Services;
using cse210_batter_csharp.Casting;
using cse210_batter_csharp.Scripting;
using System.Collections.Generic;

namespace cse210_batter_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the cast
            Dictionary<string, List<Actor>> cast = new Dictionary<string, List<Actor>>();

            // Bricks
            cast["bricks"] = new List<Actor>();
            for (int j = 0; j < 7; j++)
            {
                for (int i = 0; i < 15; i++)
                {
                    Brick brick = new Brick(Constants.BRICK_SPACE+i*(Constants.BRICK_WIDTH+Constants.BRICK_SPACE), (Constants.BRICK_SPACE*(j+1))+(Constants.BRICK_HEIGHT*j), j);
                    cast["bricks"].Add(brick);
                }
            }
                       

            // The Ball (or balls if desired)
            cast["balls"] = new List<Actor>();
            Ball ball = new Ball();
            cast["balls"].Add(ball);

            // The paddle
            cast["paddle"] = new List<Actor>();

            // TODO: Add your paddle here

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

            // TODO: Add additional actions here to handle the input, move the actors, handle collisions, etc.

            // Start up the game
            outputService.OpenWindow(Constants.MAX_X, Constants.MAX_Y, "Batter", Constants.FRAME_RATE);
            audioService.StartAudio();
            audioService.PlaySound(Constants.SOUND_START);

            Director theDirector = new Director(cast, script);
            theDirector.Direct();

            audioService.StopAudio();
        }
    }
}
