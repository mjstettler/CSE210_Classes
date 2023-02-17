using System;
using System.ComponentModel;
class Program
{
    static void Main(string[] args)
    {
        // var Reference = new Reference("Ether", 12, 27, "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them.");
        // var Reference = new Reference("James", 1, 5, -6, "If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him. But let him ask in faith, nothing wavering. For he that wavereth is like a wave of the sea driven with the wind and tossed.");
        // Menu for selecting scripture

        Console.WriteLine("\nWelcome to the Scripture memorizer! Press 'Enter' to memorize. Or type 'quit' at anytime.\n");

        Console.WriteLine("Pick a scripture to Memorize. 1 or 2\n");
        Console.WriteLine("1- Ether 12:27");
        Console.WriteLine("2- James 1:5-6\n");
        Console.Write("-->");
        int choice = Int32.Parse(Console.ReadLine());

        if (choice == 1)
        {
            var reference = new Reference("Ether", 12, 27, "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them.");
            reference.Display();
            string cont = "";
        
            while (cont != "quit")
                {
                    reference.Display();
                    cont = Console.ReadLine();
                    Console.Clear();

                    if (reference.WordsLeft() == 0)
                    {
                        reference.Display();
                        Console.WriteLine("\nYou have now memorized a Scripture! Great Job!");
                        Console.ReadLine();

                        break;
                    }
                }
                
        }
        else if (choice == 2)
        {
            var reference = new Reference("James", 1, 5, -6, "If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him. But let him ask in faith, nothing wavering. For he that wavereth is like a wave of the sea driven with the wind and tossed.");
            string cont = "";
        
            while (cont != "quit")
                {
                    reference.Display();
                    cont = Console.ReadLine();
                    Console.Clear();

                    if (reference.WordsLeft() == 0)
                    {
                        reference.Display();
                        Console.WriteLine("\nYou have now memorized a Scripture! Great Job!");
                        Console.ReadLine();

                        break;
                    }
                }
        }
        else
        {
            Console.WriteLine("Sorry that was not an option, try again.");
        }

        // string cont = "";
        
        // while (cont != "quit")
            // {
                // Reference.Display();
                // cont = Console.ReadLine();
                // Console.Clear();

                // if (Reference.WordsLeft() == 0)
                // {
                    // Reference.Display();
                    // Console.WriteLine("\nYou have now memorized a Scripture! Great Job!");
                    // Console.ReadLine();
                    
                    // break;
                // }
            // }
        

        


    }
}