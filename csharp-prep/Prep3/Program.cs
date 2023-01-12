using System;

class Program
{
    static void Main(string[] args)
    {
        int attempts = 0;
        string response = "yes";
        while (response == "yes")
        {
            Console.WriteLine("Can you guess the magic number? ");
            Random randomGenerator = new Random();
            int magic = randomGenerator.Next(1, 11);

            Console.Write("What is your guess? ");
            attempts += 1;
            int guess = Convert.ToInt32(Console.ReadLine());
            do
            {
                if (guess < magic)
                {
                    Console.WriteLine("Higher");
                    Console.Write("What is your guess? ");
                    attempts += 1;
                    guess = Convert.ToInt32(Console.ReadLine());
                }

                else if (guess > magic)
                {
                    Console.WriteLine("Lower");
                    Console.Write("What is your guess? ");
                    attempts += 1;
                    guess = Convert.ToInt32(Console.ReadLine());
                }
            } while (guess != magic);

            Console.WriteLine($"You guessed it in {attempts}! Great job!");
            attempts = 0;
            Console.WriteLine("Do you want to play again? (yes or no) ");
            response = Console.ReadLine();
        }
        Console.WriteLine("Okay thanks for playing!");
    }
}