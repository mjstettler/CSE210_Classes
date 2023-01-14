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
        int sum = 0;
        foreach (int number in numbers)
        {
            
            sum += number;
        
        }
        Console.WriteLine($"The sum is: {sum}");
        decimal average = sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {numbers.Max()}");
    }
}