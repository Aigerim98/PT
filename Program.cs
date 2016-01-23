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
        public Student(string name, string id,double gpa, string faculty){
            this.name = name;
            this.id = id;
            this.gpa = gpa;
            this.faculty = faculty;
            }
        public override string ToString()
        {
            return name + " " + id + " " + gpa + " " + faculty;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Aika", "15BD657849", 3.5, "FIT");
            Console.WriteLine(student1);


        }
 
    }
}
