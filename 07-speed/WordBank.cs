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
        public int x = 0;
        public int y = 0;

        public WordBank()
        {
            ReadWordList();
            y = r.Next(0,Constants.MAX_Y-20);
            x = r.Next(0,Constants.MAX_X-10);
        }

        protected void ReadWordList()
        {
            String[] fileWords = System.IO.File.ReadAllLines(@"Words.txt");
            _wordBank.AddRange(fileWords);
        }

        public void SelectRandomWord()
        {
            _wordIndex = r.Next(0, _wordBank.Count);
            _word = _wordBank[_wordIndex];
            _wordBank.RemoveAt(_wordIndex);
        }

        public string GetWord()
        {
            return _word;
        }

        public void MoveWord()
        {
            x -= 1;
            if (x <= (_word.Length*-10))
            {
                SelectRandomWord();
                x = r.Next(0, Constants.MAX_X-(_word.Length*10));
                y = r.Next(0, Constants.MAX_Y-20);
                
            }
        }
         
    }
}