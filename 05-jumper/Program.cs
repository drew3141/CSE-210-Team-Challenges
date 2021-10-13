using System;

namespace _05_jumper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting point for the Jumper project.");
            Director theDirector = new Director();
            theDirector.StartGame();
        }
    }
}
