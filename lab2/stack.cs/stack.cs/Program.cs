using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack.cs
{
    class Program
    {
        static Stack<string> LookIn(string path)
        {
            Stack<string> files = new Stack<string>();
            Stack<string> dirs = new Stack<string>();

            foreach (string p in Directory.GetFiles(path))
            {
                files.Push(p);
            }
            foreach (string d in Directory.GetDirectories(path))
            {
                dirs.Push(d);
            }
        }
        /*static void Look(string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            Console.WriteLine(dir.FullName + " " + dir.GetFiles().Length);
            DirectoryInfo[] d = dir.GetDirectories();
            Stack<DirectoryInfo> directories = new Stack<DirectoryInfo>();
            for (int i = 0; i < d.Length; i++)
            {
                directories.Push(Look(d[i]));
            }
        }*/
    
        static void Main(string[] args)
        {
            
        }
    }
}
