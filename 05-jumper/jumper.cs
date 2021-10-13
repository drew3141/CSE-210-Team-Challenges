using System;
<<<<<<< HEAD
=======
using System.Collections.Generic;
>>>>>>> 2b8a238e020599e88e26fb58bc25574f2f1cf039

namespace _05_jumper
{
    class Jumper
    {
<<<<<<< HEAD
        static void Main(string[] args)
        {
            Console.WriteLine("Starting point for the Jumper project.");
        }
    }
}
=======
        public int _WrongGuesses = 0;
        public List<string> displayedCharacters = new List<string>();
        //" /","_","\ ","\ ", "/","\ ", "O","/","_","_"," | ","/","\ "
        public void IncrementGuess()
        {
            _WrongGuesses++;
        }
        public void DisplayText()
        {
            Console.WriteLine("Image of Jumper");
        }
        public bool IsAlive()
        {
            if (_WrongGuesses >= 13)
            {
                return false;
            }
            return true;
        }
    }
}
>>>>>>> 2b8a238e020599e88e26fb58bc25574f2f1cf039
