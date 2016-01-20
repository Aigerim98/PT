using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "4","5","6"};
            int a = int.Parse(array[0]);
            int b = int.Parse(array[1]);
            int c = int.Parse(array[2]);
            int sum = a + b + c;
            Console.WriteLine("sum:" + sum);
            Console.ReadKey();
        }
    }
}
