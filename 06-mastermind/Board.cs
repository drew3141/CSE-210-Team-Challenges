using System;

namespace _06_mastermind
{
    class Board
    {
        public int guess1 = 0; 
        public int guess2 = 0; 
        private string lines = "---------------------";
        private string player = "Player ";
        
        public void DisplayBoard(Player one, Player two, Mastermind three)
        {
        
            DisplayLines();
            Console.Write(player + one.GetName() + ": ");
            DisplayGuess(guess1);
            Console.Write(", ");
            //three.GetHint();
            Console.WriteLine();
            Console.Write(player + two.GetName() + ": ");
            DisplayGuess(guess2);
            Console.Write(", ");
            //three.GetHint();
            Console.WriteLine();
            DisplayLines();
        }
        public void DisplayLines()
        {
            Console.WriteLine(lines);
        }
        public void DisplayGuess(int guess)
        {
            if (guess == 0)
            {
                Console.Write("----");
            }
            else
            {
                Console.Write(guess);
            }
        }
       
    
    }
}