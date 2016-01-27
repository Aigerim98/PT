using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    class Program
    {
        static void Main(string[] args)
        {
            /*FileInfo path = new FileInfo(@"C:\Users\Айгерим\Desktop\html\myfirstpage.html");
            if (path.Exists)
            {
                Console.WriteLine("file name {0}", path.Name);
                Console.WriteLine("file full path {0}", path.FullName);
                Console.WriteLine("file size {0}", path.Length);
            }
            DirectoryInfo d = new DirectoryInfo(@"C:\Users\Айгерим\Desktop\html\mediaQueries");
            if (d.Exists)
            {
                Console.WriteLine("directory name {0}", d.Name);
                Console.WriteLine("directory full path {0}", d.FullName);
            }*/
            DirectoryInfo d = new DirectoryInfo(@"C:\Users\Айгерим\Desktop\html\mediaQueries");
            if (d.Exists)
            {
                string[] files = Directory.GetFiles(@"C:\Users\Айгерим\Desktop\html\mediaQueries");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }
            }
            Console.ReadKey();
        }
    }
}
