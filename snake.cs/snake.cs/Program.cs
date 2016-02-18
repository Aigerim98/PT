using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetCursorPosition(10,10);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Name:");
            Console.SetCursorPosition(10,11);
            string name = Console.ReadLine();
            Console.WriteLine(name + "/n" + "Hello," + name + "!");
            game game = new game();
            

        }

    }
}
