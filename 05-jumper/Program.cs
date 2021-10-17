using System;

namespace _05_jumper
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("You've Jumped!! The Parachut Is Your Lifeline!");
            Director theDirector = new Director();
            theDirector.StartGame();
        }
    }
}
