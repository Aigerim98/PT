using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Complex {
        public int a;
        public int b;
        public int c;
        public int d;
        public Complex(int a, int b, int c, int d) {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex number = new Complex(2, 1, 3, 2);
            int e = number.a * number.d + number.c * number.b;
            int f = number.c * number.d;
            Console.WriteLine("2/3 + 1/2 =" + e + "/" + f);
            Console.ReadKey();
        }
    }
}
