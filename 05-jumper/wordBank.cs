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
            SelectRandomWord();
        }

        public void ReadWordList()
        {
            String[] fileWords = System.IO.File.ReadAllLines(@"Words.txt");
            _words.AddRange(fileWords);
        }

        public void SelectRandomWord()
        {
            ReadWordList();

            Random r = new Random();
            _wordIndex = r.Next(0, _words.Count);
            _secretWord = _words[_wordIndex];

            foreach (char letter in _secretWord)
            {
                _displayWord += "_";
            }
        }


        //checks if the guess from UserService is in the secret word
        public bool CheckInWord(char guess)
        {
            bool correctGuess = _secretWord.Contains(guess.ToString());

            if (correctGuess)
            {
<<<<<<< HEAD
                rightGuesses++;
                //TODO interate through secret word, everytime guess letter is encountered, replace with the correct character
=======
>>>>>>> 5aa4fe1ed58243ebab6bc530d607fbc045065ecc
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
            int length = _secretWord.Length;
            if (length == rightGuesses)
            {
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

        public bool IsVictory()
        {
            bool playerWon = false;
            if (_displayWord.ToUpper().Equals(_secretWord.ToUpper()))
            {
                playerWon = true;
            }
            return playerWon;
        }
    }
}
