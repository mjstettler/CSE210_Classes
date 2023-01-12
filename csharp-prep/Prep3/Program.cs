using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        int magic = Convert.ToInt32(Console.ReadLine());

        Console.Write("What is your guess? ");
        int guess = Convert.ToInt32(Console.ReadLine());
        do
        {
            if (guess < magic)
            {
                Console.WriteLine("Higher");
                Console.Write("What is your guess? ");
                guess = Convert.ToInt32(Console.ReadLine());
            }

            else if (guess > magic)
            {
                Console.WriteLine("Lower");
                Console.Write("What is your guess? ");
                guess = Convert.ToInt32(Console.ReadLine());
            }
        } while (guess != magic);

        Console.WriteLine("You guessed it! Great job!");
    }
}