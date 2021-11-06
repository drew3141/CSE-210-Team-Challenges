//getCurrentWord
//Do math here
using System;
using Raylib_cs;

namespace _07_speed
{
    public class Scoreboard
    {
        public int Score { get; set; }
        public Point Position { get; set; }
        private OutputService _output = null;

        public Scoreboard(OutputService outService)
        {
            _output = outService;
        }

        public void DisplayScore()
        {
            int x = Position.GetX();
            int y = Position.GetY();
            string stringScore = Score.ToString();
            _output.DrawText(300, 5, stringScore, true);
        }
    }
}