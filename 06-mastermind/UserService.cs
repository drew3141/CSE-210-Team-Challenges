using System;

namespace _06_mastermind
{
    public class UserService
    {
        public void DisplayText(string text)
        {
            Console.WriteLine(text);
        }

        public int GetNumberInput(string promptText)
        {
            Console.Write(promptText);
            string userInput = Console.ReadLine();

            int numericChoice = int.Parse(userInput);
            return numericChoice;
        }

        public string GetStringInput(string promptText)
        {
            Console.Write(promptText);
            string userInput = Console.ReadLine();

            return userInput;
        }
    }
}