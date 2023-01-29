using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Collection of string
        string[] animals = { "Cow", "Camel", "Elephant", "Horse" };
        // Create a List and add a collection
        List<string> animalsList = new List<string>();
        animalsList.AddRange(animals);
        foreach (string a in animalsList)
        Console.WriteLine(a);
        int numberInlist = animalsList.Count;
        Console.WriteLine(numberInlist);
        
    }
}