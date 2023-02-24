using System;
using System.Threading;

class Program {
    static void Main(string[] args) {
        Console.CursorVisible = false;
        string[] spinner = { "/", "-", "\\", "|" };
        int index = 0;
        while (true) {
            Console.Write("\r" + spinner[index]);
            index = (index + 1) % spinner.Length;
            Thread.Sleep(100);
        }
    }
}

