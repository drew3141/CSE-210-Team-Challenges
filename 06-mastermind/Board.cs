using System;

namespace _06_mastermind
{
    class Board
    {
        private string lines = "---------------------";
        private string player = "Player ";
        public void displayBoard(Player p1, Player p2, Mastermind m1)
        {
            DisplayLines();
            Console.WriteLine($"{player} {p1.GetName()}: {p1.GetPlayerGuess()}, {m1.getHint()}");
            Console.WriteLine($"{player} {p2.GetName()}: {p2.GetPlayerGuess()}, {m1.getLastHint()}");
            DisplayLines();
        }
        public void DisplayLines()
        {
            Console.WriteLine(lines);
        }
    }
}