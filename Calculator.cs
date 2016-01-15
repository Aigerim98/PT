using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            char c;
            c = Convert.ToChar(Console.ReadLine());
      
            if (c == '+')
            {
                Console.WriteLine(a + b);
                Console.ReadKey();
    
            }
            else if (c == '-')
            {
                Console.WriteLine(a - b);
                Console.ReadKey();
            }
            else if (c == '/')
            {
                Console.WriteLine(a / b);
                Console.ReadKey();
            }
            else if (c == '*')
            {
                Console.WriteLine(a * b);
                Console.ReadKey();
            }
            else Console.WriteLine("Wrong operation");
            Console.ReadKey();
        }
    }
}
