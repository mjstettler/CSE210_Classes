using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of Numbers, type 0 when finished.");
        
        List<int> numbers = new List<int>();

        int input = 1;
        while (input != 0)
        {
            Console.Write("Enter a number:  ");
            input = int.Parse(Console.ReadLine());
            if (input == 0)
            {
                input = 0;
            }
            else
            {
                numbers.Add(input);
            }
            
        }
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}