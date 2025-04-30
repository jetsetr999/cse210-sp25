using System;
using System.Net.NetworkInformation;

class Program
{
    static void Main(string[] args)
    {
        //1-DisplayWelcome - Displays the message, "Welcome to the Program!"
        DisplayMessage();

        //2-PromptUserName - Asks for and returns the user's name (as a string)
        string userName = PromptName();

        //3-PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
        int userNumber = PromptNumber();

        //4-SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
        int SquaredNumber = SqNumber(userNumber);

        //5-DisplayResult - Accepts the user's name and the squared number and displays them.
        DisplayResults(userName, SquaredNumber);

        static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            return name;
        }

        static int PromptNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());

            return number;
        }

        static int SqNumber(int number)
        {
            int square = number * number;

            return square;
        }

        static void DisplayResults(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }        
    }
}