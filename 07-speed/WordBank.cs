// wordbank, Logic
// while loop?? Iterate through a list of currentwords
using System;
using System.Collections.Generic;

namespace _07_speed
{
    public class WordBank
    {
        private List<string> _wordBank = new List<string>();
        Random r = new Random();
        private string _word = "";
        private int _wordIndex = -1;

        public WordBank()
        {
            ReadWordList();
            
        }

        protected void ReadWordList()
        {
            String[] fileWords = System.IO.File.ReadAllLines(@"Words.txt");
            _wordBank.AddRange(fileWords);
        }

        public string SelectRandomWord()
        {
            _wordIndex = r.Next(0, _wordBank.Count);
            _word = _wordBank[_wordIndex];
            _wordBank.RemoveAt(_wordIndex);

            return _word;
        }
         
    }
}