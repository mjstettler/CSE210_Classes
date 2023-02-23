using System;

class ProgressAnimation
{
    public void DisplayAnimation()
        {
            int num = 0;
        string progress = "";
        int loopOut = 0;

        do
        {
            Console.Write(progress);
            int loopIN = 0;
            do
            {
                Console.CursorVisible= false;

                Console.Write($"\\");
                Thread.Sleep(80);
                Console.Write("\b"); // Erase the + character
                Console.Write($"|"); // Replace it with the - character
                Thread.Sleep(80);
                Console.Write("\b"); // Erase the + character
                Console.Write("/");
                Thread.Sleep(80);
                Console.Write("\b"); // Erase the + character
                Console.Write($"-"); // Replace it with the - character
                Thread.Sleep(80);
                Console.Write("\b"); // Erase the + character
                Console.Write($"\\");
                Thread.Sleep(80);
                Console.Write("\b"); // Erase the + character
                Console.Write($"|"); // Replace it with the - character
                Thread.Sleep(80);
                Console.Write("\b"); // Erase the + character
                Console.Write("/");
                Thread.Sleep(80);
                Console.Write("\b"); // Erase the + character
                Console.Write($"-"); // Replace it with the - character
                Thread.Sleep(80);
                Console.Write("\b"); // Erase the + character

                loopIN++;
            } while (loopIN <2);
            progress = "..";

            loopIN = 0;
            loopOut++;


        } while (loopOut <4);
    }
}