using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace max_min.cs
{
    class Program
    {
        static void max_min()
        {
            FileStream fread = new FileStream(@"C:\test\input.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            FileStream fwrite = new FileStream(@"C:\test\output.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fread);
            StreamWriter sw = new StreamWriter(fwrite);
            string[] str = sr.ReadLine().Split(',');
            int[] a = new int[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                a[i] = int.Parse(str[i]);
            }
            int min = 0, max = 0;
            min = a[0];
            max = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            sw.WriteLine("max:" + max + " " + "min:" + min);

            sw.Close();
            sr.Close();
            fwrite.Close();
            fread.Close();
        }
        static void Main(string[] args)
        {
            max_min();
            Console.ReadKey();
        }
    }
}
