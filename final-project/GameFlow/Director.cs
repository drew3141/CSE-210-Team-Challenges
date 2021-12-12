using System;
using Raylib_cs;
using System.Collections.Generic;
using Final_Project.Casting;
using Final_Project.Services;
using Final_Project.Scripting;

namespace Final_Project.GameFlow
{
    /// <summary>
    /// The director is responsible to direct the game, including to keep track of all
    /// the actors and to control the sequence of play.
    /// 
    /// Stereotype:
    ///     Controller
    /// </summary>
    public class Director
    {
        private bool _keepPlaying = true;
        private Dictionary<string, List<Actor>> _cast;
        private Dictionary<string, List<Action>> _script;

        public Director(Dictionary<string, List<Actor>> cast, Dictionary<string, List<Action>> script)
        {
            _cast = cast;
            _script = script;
        }

        /// <summary>
        /// This method starts the game and continues running until it is finished.
        /// </summary>
        public void Direct()
        {
            while (_keepPlaying)
            {
                Player p = (Player)_cast["player"][0];
                CueAction("input");
                CueAction("update");
                CueAction("output");
                if (!p.isAlive)
                {
                    Reset();
                }
                if (Raylib_cs.Raylib.WindowShouldClose())
                {
                    _keepPlaying = false;
                }
            }
        }


        public void Reset()
        {
            Player p = (Player)_cast["player"][0];
            ControlActorsAction c = (ControlActorsAction)_script["input"][0];
            c.currentRoom = 1;
            p.isAlive = true;
            p.GravityModifier = 1;
            p.SetPosition(new Point(Constants.MAX_X/2, Constants.MAX_Y-200));
            c.MoveNextRoom(_cast);
        }

        /// <summary>
        /// Executes all of the actions for the provided phase.
        /// </summary>
        /// <param name="phase"></param>
        private void CueAction(string phase)
        {
            List<Action> actions = _script[phase];

            foreach (Action action in actions)
            {
                action.Execute(_cast);
            }
        }

    }
}
