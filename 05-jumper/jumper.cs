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
        
        //Adds/Replaces all characters in the textImage list; resets _WrongGuesses
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
        
        //Increments wrongGuess counter and replaces a character in the jumper image with a blank space
        public void IncrementGuess()
        {
            _WrongGuesses++;
            displayedCharacters[_WrongGuesses-1]=' ';
        }

        //Displays the text image of the Jumper
        public void DisplayText()
        {
            for (int i = 0; i <= 4; i++)
            {
                Console.Write(displayedCharacters[i]);
            }
            Console.WriteLine($"\n {displayedCharacters[5]}  {displayedCharacters[6]}");
            Console.Write(" ");
            for (int i = 7; i <= 9; i++)
            {
                Console.Write(displayedCharacters[i]);
            }
            Console.WriteLine($"\n {displayedCharacters[10]}{displayedCharacters[11]}{displayedCharacters[12]}");
            Console.WriteLine($"  {displayedCharacters[13]}{displayedCharacters[14]}");
            Console.WriteLine("\n ^^^^^");
        }

        //Function to return boolean if the jumper is Alive
        public bool IsAlive()
        {
            if (_WrongGuesses >= 14)
            {
                return false;
            }
            return true;
        }
    }
}
