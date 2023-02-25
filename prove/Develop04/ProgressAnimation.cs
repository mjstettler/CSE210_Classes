using System;

class ProgressAnimation
{
    public List<string> _increasing = new List<string>();

    public ProgressAnimation()
    {
        _increasing.Add(".");
        _increasing.Add(".");
        _increasing.Add(".");
        _increasing.Add(".");
        _increasing.Add(".");
        _increasing.Add(".");
        _increasing.Add(".");
        _increasing.Add(".");
    }
    public void DisplayAnimation()
        {
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


        } while (loopOut <3);
        Console.CursorVisible = true;
    }



    public void SecondAnimation(int aSeconds)
    {   
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(aSeconds);
        Console.CursorVisible = false;
        while (DateTime.Now < endTime)
        {    
            foreach (string c in _increasing)
            {
                Console.Write(c);
                Thread.Sleep(100);
            }
            foreach (string c in _increasing)
            {
                Console.Write("\b \b");
                Thread.Sleep(100);
            }
        }
        Console.CursorVisible = true;
    }
}


