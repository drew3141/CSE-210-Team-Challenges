using System;
using System.Collections.Generic;

namespace _05_jumper
{
    public class WordBank
    {
        public List<string> _words = new List<string>();
        public String _secretWord = "";
        public int _wordIndex = -1;
        public String _displayWord = "";
        public int rightGuesses = 0;

        public WordBank()
        {
            ReadWordList();
        }
        public void ReadWordList()
        {
            String[] fileWords = System.IO.File.ReadAllLines(@"Words.txt");
            _words.AddRange(fileWords);
        }
        //public void SelectRandomWord()
        public string SelectRandomWord()
        {
            Random r = new Random();
            _wordIndex = r.Next(0, _words.Count);
            _secretWord = _words[_wordIndex];
<<<<<<< HEAD
            Console.WriteLine(_secretWord);
=======
            _displayWord = "";
>>>>>>> d0d67bb60896835346d38f060a923771db926fc2

            foreach (char letter in _secretWord)
            {
                _displayWord += "_";
            }
            return _secretWord;
        }

        //checks if the guess from UserService is in the secret word
        public bool CheckInWord(char guess)
        {
            bool correctGuess = _secretWord.Contains(guess.ToString());

            if (correctGuess)
            {
                rightGuesses++;
                //TODO interate through secret word, everytime guess letter is encountered, replace with the correct character
                for (int i =0; i < _secretWord.Length; i++)
                {
                    char letter = _secretWord[i];
                    if (letter == guess)
                    {
                        _displayWord = _displayWord.Remove(i, 1);
                        _displayWord = _displayWord.Insert(i, guess.ToString());
                    }
                }
            }

            return correctGuess;
        }
        public bool isGameWon()
        {
            int length = _displayWord.Length;
            if (length == (rightGuesses-1))
            {
                Console.WriteLine("You have won!");
                return true;
            }
            else 
            {
                return false;
            }
        }

        //displays the word and has an if statement disallowing
        //the guesser to guess the same letter more than once.
        public void DisplayWord()
        {
            Console.WriteLine(_displayWord);
        }
    }
}
