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
        static void LookIn(string path)
        {
            //Stack<string> files = new Stack<string>();
            Stack<string> dirs = new Stack<string>();

            dirs.Push(path);
            while (dirs.Count > 0)
            {
                DirectoryInfo current = new DirectoryInfo(dirs.Pop());
                DirectoryInfo[] subDirs = current.GetDirectories();
                FileInfo[] files = current.GetFiles();
                Console.WriteLine(current);
                foreach(FileInfo file in files)
                {
                    Console.WriteLine(file);
                }
                foreach(DirectoryInfo d in subDirs)
                {
                    dirs.Push(d.FullName);
                }
            }
                
        }
            /*foreach (string p in Directory.GetFiles(path))
            {
                files.Push(p);
            }
            foreach (string d in Directory.GetDirectories(path))
            {
                dirs.Push(d);
            }*/
        static void Main(string[] args)
        {
            LookIn(@"C:\Users\Айгерим\Desktop\html");
            Console.ReadKey();
        }
    }
}
