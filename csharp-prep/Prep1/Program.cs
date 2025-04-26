using System;

class Program
{
    static void Main(string[] args)
    {
        // get user input
        Console.Write("What is your first name? ");
        string firstname = Console.ReadLine();
        Console.Write("What is your last name? ");
        string lastname = Console.ReadLine();
                
        // display user input
        Console.WriteLine($"Your name is {lastname}, {firstname} {lastname}.");
    }
}