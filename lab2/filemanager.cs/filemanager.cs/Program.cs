using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace filemanager.cs
{
    class Program
    {
        static void LookIn(string path)
        {
            Stack<string> dirs = new Stack<string>();
            dirs.Push(path);
            while (dirs.Count > 0)
            {
                DirectoryInfo cur = new DirectoryInfo(dirs.Pop());
                DirectoryInfo[] subd = cur.GetDirectories();
                FileInfo[] fil = cur.GetFiles();
                Console.WriteLine(cur);
                foreach(FileInfo files in fil)
                {
                    Console.WriteLine(files);
                }
                foreach(DirectoryInfo d in subd)
                {
                    dirs.Push(d.FullName);
                }
            }
        }
        static void Main(string[] args)
        {
            string path = @"C:\Users\Айгерим\Documents\Visual Studio 2015";
            DirectoryInfo dir = new DirectoryInfo(path);
            List<FileSystemInfo> items = new List<FileSystemInfo>();
            items.AddRange(dir.GetDirectories());
            items.AddRange(dir.GetFiles());
            int index = 0;
            while (true)
            {
                for (int i = 0; i < items.Count; i++)
                {
                    if (i == index)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                    }
                    if (items[i].GetType() == typeof(FileInfo))
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.WriteLine(items[i].Name);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                ConsoleKeyInfo button = Console.ReadKey();
                if(button.Key == ConsoleKey.UpArrow)
                {
                    if (index > 0)
                    {
                        index--;
                    }
                }
                if (button.Key == ConsoleKey.DownArrow)
                {
                    if (index < items.Count - 1)
                        index++;
                }
                if(button.Key == ConsoleKey.Enter)
                {

                    if (items[index].GetType() == typeof(DirectoryInfo))
                    {
                        path = items[index].FullName;
                        dir = new DirectoryInfo(path);
                        items.Clear();
                        //LookIn(path);
                        items.AddRange(dir.GetDirectories());
                        items.AddRange(dir.GetFiles());
                        index = 0;
                    }
                }
                if (button.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    dir =  dir.Parent;
                    items.Clear();
                    items.AddRange(dir.GetDirectories());
                    items.AddRange(dir.GetFiles());
                    index = 0;
                }
                Console.Clear();
            }
        }
    }
}
