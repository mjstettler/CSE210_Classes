using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade point percentage? ");
        string percentage = Console.ReadLine();
        int number = int.Parse(percentage);

        string letter = "";
        string[] passing = {"A", "B", "C"};
        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80 && number < 90 && number >79)
        {
            letter = "B";
        }
        else if (number >= 70 && number < 80 && number >69)
        {
            letter = "C";
        }  
        
        else if (number >= 60 && number < 70 && number >59)
        {
            letter = "D";
        }        
        else if (number < 60)
        {
            letter = "F";
        }

        Int32 lastNumber = number % 10;
        string sign = "";
        if (lastNumber >= 7 && letter == "B" || letter == "C" || letter == "D")
        {
            sign = "+";
        }
        else if (lastNumber > 3 && lastNumber < 7)
        {
            sign = "";
        }
        else if (lastNumber < 3 && letter == "A" ||letter == "B" ||letter == "C" ||letter == "D")
        {
            sign = "-";
        }




        Console.WriteLine($"Your grade is: {letter}{sign}.");
        if (passing.Contains(letter))
        {
            Console.WriteLine("Congrats on Passing this class!");
        }
        else
        {
            Console.WriteLine("I am sorry but you did not pass the class, better luck next time.");
        }

    }
}