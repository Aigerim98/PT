using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class Complex
    {
        public int a, b;
        public Complex(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public Complex Add(Complex d)
        {
            int x = this.a * d.b + d.a * this.b;
            int y = this.b * d.b;

            int k = 0;
            for (int i = 1; i <= Math.Min(x, y); i++)
            {
                if (x % i == 0 && y % i == 0)
                    k = i;
            }
            x /= k;
            y /= k;
            Complex c = new Complex(x, y);
            return c;
            
        }
        public override string ToString()
        {
            return a + "/" + b;
        }
        public static Complex operator +(Complex c1, Complex c2)
        {
            Complex c3 = new Complex(c1.a * c2.b + c2.a * c1.b, c1.b * c2.b);
            return c3;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Complex c = new Complex(5, 6);
            Complex d = new Complex(6, 7);
            Complex w = c + d;
            Console.WriteLine(w);
            //Console.WriteLine(c.Add(d));
            Console.ReadKey();
        }
    }
}