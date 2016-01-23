using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication17
{
    class Program
    {
        static void Main(string[] args)
        {
            //решето эратосфена
            int n;
            n = int.Parse(Console.ReadLine());
            bool[] isPrime = new bool[n];//создание массива типа bool
            for (int i = 0; i < n; i++)
            {
                isPrime[i] = true;//заполнение массива true
            }
            for (int i = 2; i < n; i++)
            {
                for (int j = i + i; j < n; j = j + i)//изначально цикл начинается с 2 и во втором вложенном цикле он пробегается по числам кратным на 2 и зачёркивает их, затем выходит из цикла и начинает проверять 3
                {
                    isPrime[j] = false;
                }
            }
            for (int i = 2; i < n; i++)
            {
                if (isPrime[i])
                    Console.WriteLine(i);
            }
            Console.ReadKey();


        }
    }
}
