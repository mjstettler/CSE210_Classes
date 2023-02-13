using System;
using System.ComponentModel;
class Program
{
    static void Main(string[] args)
    {
        var Reference = new Reference("Ether", 12, 27, "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them.");
        
        // Menu for selecting scripture

        Console.WriteLine("\nWelcome to the Scripture memorizer! Press 'Enter' to memorize.\n");


        Reference.Display();

        

        

        




        int choice = Int32.Parse(Console.ReadLine());
    }
}