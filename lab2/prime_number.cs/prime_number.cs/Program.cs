using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_number.cs
{
    class Program
    {
        public static bool isPrime(int a)
        {
            if (a < 2)
                return false;
            for (int i = 2; i < a; i++)
            {
                if (a % i == 0)
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {

            FileStream fread = new FileStream(@"C:\test\input.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            FileStream fwrite = new FileStream(@"C:\test\output.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fread);
            StreamWriter sw = new StreamWriter(fwrite);
            string[] str = sr.ReadLine().Split(',');
            int[] a = new int[str.Length];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(str[i]);
            }
            Array.Sort(a);
            int min = 1000000000;
            for (int i = 0; i < a.Length; i++)
            {
                if (isPrime(a[i]))
                {
                    min = a[i];
                    break;
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            sw.WriteLine(min);
            sw.Close();
            sr.Close();
            fread.Close();
            fwrite.Close();
            Console.WriteLine(min);
            Console.ReadKey();
        }
    }
}
