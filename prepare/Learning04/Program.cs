using System;

class Program
{
    static void Main(string[] args)
    {
        Assignments assign1 = new Assignments("John Smith", "American History");
        Console.WriteLine(assign1.GetSummary());

        MathAssignments assign2 = new MathAssignments("Peter Parker", "Linear Equations", 12.1, "1-32");
        Console.WriteLine(assign2.GetSummary());
        Console.WriteLine(assign2.GetHomeWorkList());

        WritingAssignments assign3 = new WritingAssignments("Bob Crachet", "Creative Writing", "What would the world be like if I was undaunted?");
        Console.WriteLine(assign3.GetSummary());
        Console.WriteLine(assign3.GetWritingInfo());





    }
}