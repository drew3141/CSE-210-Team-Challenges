using System;
using System.Linq;

namespace _06_mastermind
{
    public class Mastermind
    {
        private string code = "";
        private string guess = "----";
        private string previousGuess = "----";
        private string hint = "----";
        private string lastHint = "----";

        char[] hintList = {'*', '*', '*', '*'};

        public void setGuess(string userInput){
            previousGuess= guess;
            guess = userInput;
        }
        public string getGuess()
        {
            return guess;
        }
        public void setCode()
        {
            Random r = new Random();
            int number = r.Next(1000, 9999);
            code = number.ToString();
        }
        public void setHint()
        {
            char[] codeArray = code.ToCharArray();
            char[] guessArray = guess.ToCharArray();
            if(guessArray[0] == codeArray[0])
            {
                hintList[0] = 'X';
            }
            if(guessArray[1] == codeArray[1])
            {
                hintList[1] = 'X';
            }
            if(guessArray[2] == codeArray[2])
            {
                hintList[2] = 'X';
            }
            if(guessArray[3] == codeArray[3])
            {
                hintList[3] = 'X';
            }
            if(codeArray.Contains(guessArray[0]))
            {
                hintList[0] = 'O';
            }
            if(codeArray.Contains(guessArray[1]))
            {
                hintList[1] = 'O';
            }
            if(codeArray.Contains(guessArray[2]))
            {
                hintList[2] = 'O';
            }
            if(codeArray.Contains(guessArray[3]))
            {
                hintList[3] = 'O';
            }
            else{
                Console.WriteLine(code);
            }
            // else if(guessArray.contains())
            // else{
            //     hintList = hintList;
            // }
            hint = new string(hintList);
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