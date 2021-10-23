using System;

namespace _06_mastermind
{
    public class Mastermind
    {
        private string code = "";
        private string guess = "----";
        private string previousGuess = "----";
        private string hint = "----";
        private string lastHint = "----";

        public void setGuess(string userInput){
            previousGuess= guess;
            guess = userInput;
        }
        public void setCode()
        {
            Random r = new Random();
            int number = r.Next(1000, 9999);
            code = number.ToString();
        }
        public void setHint()
        {
            lastHint = hint;
            hint = "1234";
        }
        public string getHint()
        {
            return hint;
        }
        public string getLastHint()
        {
            return lastHint;
        }
        public bool hasWon()
        {
            if(code == guess){
                return true;
            }
            else{
                return false;
            }
        }
        public void displayGuess()
        {
            Console.Write($"{guess}, {hint}");
        }
        public void displayPreviousGuess()
        {
            Console.Write($"{previousGuess}, {hint}");
        }
    }

}