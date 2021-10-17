using System;
namespace _05_jumper
{
public class UserService
{
public string getUserInput()
{
    Console.WriteLine("Please enter a letter: ");
    string userLetter = Console.ReadLine();
    return userLetter;
}
}
}