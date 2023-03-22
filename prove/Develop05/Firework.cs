using System;
using System.Threading;

public class Firework
{
    public void Main()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.CursorVisible = false;

        while (true)
        {
            Console.Clear();
            DrawFirework();
            Thread.Sleep(100);
        }
    }

    public void DrawFirework()
    {
        Console.Clear();
        int centerX = Console.WindowWidth / 2;
        int centerY = Console.WindowHeight / 2;

        for (int i = 0; i < 20; i++)
        {
            Console.SetCursorPosition(centerX, centerY);

            Console.Write("*");

            int x = centerX;
            int y = centerY;

            for (int j = 0; j < 10; j++)
            {
                int dx = (int)(10 * (2 * new Random().NextDouble() - 1));
                int dy = (int)(10 * (2 * new Random().NextDouble() - 1));

                x += dx;
                y += dy;

                if (x >= Console.WindowWidth || x < 0 || y >= Console.WindowHeight || y < 0)
                {
                    break;
                }

                Console.SetCursorPosition(x, y);

                Console.Write(".");
            }

            Thread.Sleep(100);
            Console.Clear();
        }
    }
}
