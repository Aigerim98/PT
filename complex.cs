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
            Complex c = new Complex(a, b);
            int sum = 0;
            if (c.b % this.b == 0 && c.b > this.b)
            {
                sum = c.b;
            }
            else if (this.b % c.b == 0 && this.b > c.b)
            {
                sum = this.b;
            }

            else if (c.b % this.b != 0 && c.b > this.b)
            {
                for (int i = 0; i <= this.b * c.b; i++)
                {
                    if (i % c.b == 0 && i % this.b == 0)
                    {
                        sum = i;
                    }
                }
            }
            else if (c.b % this.b != 0 && this.b > c.b)
            {
                for (int i = 0; i <= this.b * c.b; i++)
                {
                    if (i % this.b == 0 && i % c.b == 0)
                    {
                        sum = i;
                    }
                }
            }
            else if (this.b == c.b)
            {
                sum = this.b;
            }
            int divizer = (this.a * (sum / this.b)) + (c.a * (sum / c.b));
            return new Complex(divizer,sum);
        }
        public override string ToString()
        {
            return a + "/" + b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Complex c = new Complex(5, 6);
            Complex d = new Complex(6, 7);
            Console.WriteLine(c.Add(d));
            Console.ReadKey();
        }
    }
}