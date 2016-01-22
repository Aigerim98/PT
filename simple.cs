using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class Program
    {
        static bool isPrime(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            /*int n;
            n = int.Parse(Console.ReadLine());
            bool[] isPrime = new bool[n];
            for (int i = 0; i < n; i++)
            {
                isPrime[i] = true;
            }
            for (int i = 2; i <= n; i++)
            {
                for (int j = i + i; j <= n; j = j + i)
                {
                    isPrime[j] = false;
                }
            }
            for (int i = 2; i < n; i++)
            {
                if (isPrime[i])
                    Console.WriteLine(i);
            }
            Console.ReadKey();*/

            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                if (isPrime(i))
                {
                    Console.WriteLine("The number {0} is a simple", i.ToString());
                }
               
            }
            Console.ReadKey();
        }
    }
}
