using System;

class ProgressAnimation
{
    public void DisplayAnimation()
        {
            int num = 0;
        string progress = "";

        while (num != 1)
        {
            Console.Write(progress);
            int loopNum = 0;
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

                loopNum++;
            } while (loopNum <2);
            progress = "-";

            loopNum = 0;


        }
    }
}