using System;

using System.Collections.Generic;

namespace _05_jumper
{
    class Jumper
    {
        public int _WrongGuesses = 0;
        public string characterList = @"/‾‾‾\\/\O//|\/\";
        public List<char> displayedCharacters = new List<char>();
        //" /","_","\ ","\ ", "/","\ ", "O","/","_","_"," | ","/","\ "
        public void initializeJumper()
        {
            if (displayedCharacters.Count < 1)
            {
                for (int i = 0; i < characterList.Length; i++)
                {
                    displayedCharacters.Add(characterList[i]);
                }
            }
            else
            {
                for (int i = 0; i < characterList.Length; i++)
                {
                    displayedCharacters[i]=characterList[i];
                }
            }
            _WrongGuesses=0;
        }
        public void IncrementGuess()
        {
            _WrongGuesses++;
            displayedCharacters[_WrongGuesses-1]=' ';
        }
        public void DisplayText()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write(displayedCharacters[i]);
            }
            Console.WriteLine();
            Console.WriteLine($"{displayedCharacters[5]}  {displayedCharacters[6]}");
            Console.Write(" ");
            for (int i = 7; i < 10; i++)
            {
                Console.Write(displayedCharacters[i]);
            }
            Console.WriteLine();
            Console.WriteLine($" {displayedCharacters[10]}{displayedCharacters[11]}{displayedCharacters[12]}");
            Console.WriteLine($"  {displayedCharacters[13]}{displayedCharacters[14]}");
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
