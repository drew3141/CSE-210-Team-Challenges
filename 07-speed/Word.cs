// wordbank, Logic
// while loop?? Iterate through a list of currentwords
using System;
using System.Collections.Generic;

namespace _07_speed
{
    public class Word : Actor
    {
        Random r = new Random();
        WordBank _words = new WordBank();
        public Word()
        {
            int y = r.Next(0,Constants.MAX_Y-40);
            int x = r.Next(0,Constants.MAX_X-10);
            _position = new Point(x,y);
            _velocity = new Point(-1,0);
            SetNewWord(_words.SelectRandomWord());
        }       
        
        private void SetNewWord(string w)
        {
            _text = w;
        }
        public void MoveWord()
        {
            MoveNext();
            if (_position.GetX() <= (_text.Length*-10))
            {
                ResetWord();    
            }
        }

        public void ResetWord()
        {
            _position = new Point(Constants.MAX_X, r.Next(0, Constants.MAX_Y-40));
            SetNewWord(_words.SelectRandomWord());   
        }
        
    }
}


