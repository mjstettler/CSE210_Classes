using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string UserName = PromptUserName();
        int UserNumber = PromptUserNumber();
        int squared = SquareNumber(UserNumber);
        DisplayResults(UserName, squared);
        
        
        
        
        
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the function program!");

        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name? ");
            string UserName = Console.ReadLine();
            return UserName;
        }
        
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int UserNumber = int.Parse(Console.ReadLine());
            return UserNumber;
        }

        static int SquareNumber(int UserNumber)
        {
            int squared = UserNumber * UserNumber;
            return squared;
        }

        static void DisplayResults(string UserName, int UserNumber)
        {
            Console.WriteLine($"{UserName}, the square of your number is {UserNumber}");
        }
    }
}