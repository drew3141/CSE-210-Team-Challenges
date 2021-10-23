using System;

namespace _06_mastermind
{
    class Player
    {
        private string _name;
        private string playerGuess = "----";

        public void SetName(string name)
        {
            _name = name;
        }
        public string GetName()
        {
            return _name;
        }
        public void SetGuess(string guess)
        {
            playerGuess = guess;
        }
        public string GetPlayerGuess()
        {
            return playerGuess;
        }
    }
}
