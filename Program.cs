using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Student {
        public string name;
        public string id;
        public double gpa;
        public string faculty;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.name = "Aigerim";
            student1.id = "15BD02052";
            student1.gpa = 3.5;
            student1.faculty = "FIT";
            Console.WriteLine(student1.name +" "+  student1.id +" "+ student1.gpa +" "+ student1.faculty);
            Console.ReadKey();
        }
    }
}
