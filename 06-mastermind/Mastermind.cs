using System;

namespace _06_mastermind
{
    public class Mastermind
    {
        private string code;
        private string guess;

        public string setGuess(){
            UserService r = new UserService();
            string guess = r.GetStringInput("l");
            return guess;
        }
        public string move()
        {
            string test = "hello";
            return test;
        }
        public string createCode()
        {
            Random r = new Random();
            int number = r.Next(1000, 9999);
            code = number.ToString();
            return code;
        }
        public string[] getHint()
        {
            var hint = new string[] {"P","P","P","P" };
            string[] guess_list = guess.Split();
            string[] code_list = code.Split();
            if(guess_list[0] == code_list[0]){
                hint[0] = "X";
            }
            else if(guess_list[1] == code_list[1]){
                hint[1] = "X";
            }
            else if(guess_list[2] == code_list[2]){
                hint[2] = "X";
            }
            else if(guess_list[3] == code_list[3]){
                hint[3] = "X";
            }
            return hint;

        }
        public bool hasWon()
        {
            bool hasWon = false;
            if(code == guess){
                hasWon = true;
            }
            else{
                hasWon = false;
            }
            return hasWon;
        }
    }

}