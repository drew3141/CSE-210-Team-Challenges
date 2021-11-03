// wordbank, Logic
// while loop?? Iterate through a list of currentwords
using System;
using System.Collections.Generic;

namespace _07_speed
{
    public class Word
    {
        protected List<string> _words = new List<string>();
        protected string _word = "";
        protected int _wordIndex = -1;

        protected Word()
        {
            ReadWordList();
        }

        protected void ReadWordList()
        {
            String[] fileWords = System.IO.File.ReadAllLines(@"Words.txt");
            _words.AddRange(fileWords);
        }

        protected string SelectRandomWord()
        {
            Random r = new Random();
            _wordIndex = r.Next(0, _words.Count);
            _word = _words[_wordIndex];
            Console.WriteLine(_word);

            return _word;
        }
         
    }
}