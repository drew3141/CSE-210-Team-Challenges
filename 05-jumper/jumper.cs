using System;

using System.Collections.Generic;

namespace _05_jumper
{
    public class Jumper
    {
        public int _WrongGuesses = 0;
        public string characterList = @"___/\\/\O//|\/\";
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
            Console.WriteLine($" {displayedCharacters[0]}{displayedCharacters[1]}{displayedCharacters[2]}");
            Console.WriteLine($"{displayedCharacters[3]}   {displayedCharacters[4]}");
            Console.WriteLine($"{displayedCharacters[5]}   {displayedCharacters[6]}");
            Console.WriteLine($" {displayedCharacters[7]}{displayedCharacters[8]}{displayedCharacters[9]}");
            Console.WriteLine($" {displayedCharacters[10]}{displayedCharacters[11]}{displayedCharacters[12]}");
            Console.WriteLine($" {displayedCharacters[13]}{displayedCharacters[14]}");
            Console.WriteLine("\n ^^^^^");
        }

        //Function to return boolean if the jumper is Alive
        public bool IsAlive()
        {
            if (_WrongGuesses >= 15)
            {
                return false;
            }
            return true;
        }
    }
}
