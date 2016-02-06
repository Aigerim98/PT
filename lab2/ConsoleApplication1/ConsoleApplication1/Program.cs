using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo button = Console.ReadKey();
            while (true)
            {
                if (button.Key == ConsoleKey.UpArrow)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("up");
                }
                if (button.Key == ConsoleKey.DownArrow)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("down");
                }
                if (button.Key == ConsoleKey.LeftArrow)
                {
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("left");
                }
                if (button.Key == ConsoleKey.RightArrow)
                {
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("right");
                }
                if (button.Key == ConsoleKey.Enter)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                }
                if (button.Key == ConsoleKey.Escape)
                {
                    return;
                }
            }
        }
    }
}
