using System;

namespace Draw
{
    class Program
    {
        static void Main()
        {
            int x = 0, y = 0;
            ConsoleKey gomb;
            int ww = Console.WindowWidth;
            int wh = Console.WindowHeight;
            bool isRunning = true; 

            do
            {
                Console.SetCursorPosition(x, y);
                gomb = Console.ReadKey(true).Key;

                if (gomb == ConsoleKey.UpArrow && y > 0) y--;
                if (gomb == ConsoleKey.DownArrow && y < wh - 1) y++;
                if (gomb == ConsoleKey.LeftArrow && x > 0) x--;
                if (gomb == ConsoleKey.RightArrow && x < ww - 1) x++;

                switch (gomb)
                {
                    case ConsoleKey.D1:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;

                    case ConsoleKey.D2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;

                    case ConsoleKey.D3:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;

                    case ConsoleKey.D4:
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                    case ConsoleKey.Spacebar:
                        Console.SetCursorPosition(x, y);
                        Console.Write('█');
                        break;
                    case ConsoleKey.V:
                        Console.SetCursorPosition(x, y);
                        Console.Write('▓');
                        break;
                    case ConsoleKey.B:
                        Console.SetCursorPosition(x, y);
                        Console.Write('▒');
                        break;
                    case ConsoleKey.N:
                        Console.SetCursorPosition(x, y);
                        Console.Write('░');
                        break;
                }

                if (gomb == ConsoleKey.Tab)
                {
                    while (true)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.Write('█');

                        gomb = Console.ReadKey(true).Key;

                        if (gomb == ConsoleKey.UpArrow && y > 0) y--;
                        if (gomb == ConsoleKey.DownArrow && y < wh - 1) y++;
                        if (gomb == ConsoleKey.LeftArrow && x > 0) x--;
                        if (gomb == ConsoleKey.RightArrow && x < ww - 1) x++;

                        if (gomb == ConsoleKey.Spacebar) break;
                    }
                }

                if (gomb == ConsoleKey.Escape)
                {
                    isRunning = false; 
                }

            } while (isRunning); 
        }
    }
}
