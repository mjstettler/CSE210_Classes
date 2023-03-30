using System;

class Program
{
    static void Main(string[] args)
    {
        string today = DateTime.Now.ToString("dd MMMM yyyy");
        Console.WriteLine(today);
    }
}