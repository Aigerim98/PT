using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string s = "12345678910";
              char[] array = s.ToCharArray();
              int sum = 0;


                  for (int i = 0; i < s.Length; i++)
                  {
                  
                      sum += (array[i] - '0');
                  }


              Console.WriteLine(sum);
              Console.ReadKey();
            /*string s = "Hello, world";
            char[] array = s.ToCharArray();
            for (int i = 0; i < s.Length; i++) {
                Console.WriteLine(array[i]);
            }
            Console.ReadKey();*/
            string path = @"C:\Users\Айгерим\Desktop\c++\far2.0\new_file.txt";
            FileInfo f = new FileInfo(path);
            if (f.Exists)
            {
                Console.WriteLine(f.Name);
            }
            if (!File.Exists(path)) {

            }


        }
    }
}
