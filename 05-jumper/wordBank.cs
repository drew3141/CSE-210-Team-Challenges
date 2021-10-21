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
        public String _alreadyGuessed = "";

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
            Console.WriteLine(_secretWord);
            _displayWord = "";

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
            _alreadyGuessed+=$"{guess.ToString()} ";
            if (correctGuess)
            {
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
            if (_secretWord == _displayWord)
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
            Console.WriteLine($"Guesses: {_alreadyGuessed}");
            Console.WriteLine(_displayWord);
        }
    }
}
