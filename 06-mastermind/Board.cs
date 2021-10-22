using System;

namespace _06_mastermind
{
    class Board
    {
        private string lines = "---------------------";
        private string player = "Player ";
        
        public void DisplayBoard(Player one, Player two)
        {
            DisplayLines();
            Console.WriteLine(player + one.GetName() + ": ");
            Console.WriteLine(player + two.GetName() + ": ");
            DisplayLines();
        }
        public void DisplayLines()
        {
            Console.WriteLine(lines);
        }
    
    }
}