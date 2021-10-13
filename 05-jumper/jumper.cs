using System;
using System.Collections.Generic;

namespace _05_jumper
{
    class Jumper
    {
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
