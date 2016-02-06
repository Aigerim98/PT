using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3.cs
{
    class Program
    {
        static void showInfo(string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            Console.WriteLine(dir.FullName + " " + dir.GetFiles().Length);
            DirectoryInfo[] d = dir.GetDirectories();
            for (int i = 0; i < d.Length; i++)
            {
                showInfo(d[i].Name);
            }                   
        }
        static void Main(string[] args)
        {
            showInfo(@"C:\Users\Айгерим\Desktop\c++\far2.0");
            Console.ReadKey();
        }
    }
}
