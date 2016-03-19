using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addSubject.cs
{
    class Program
    {
        class Student
        {
            public string name;
            public string id;
            public double gpa;
            public string faculty;
            public List<Subject> subjects = new List<Subject>();

            public Student(string name, string id, double gpa, string faculty)
            {
                this.name = name;
                this.id = id;
                this.gpa = gpa;
                this.faculty = faculty;
            }
            public void add_subject(Subject subject)
            {
                subjects.Add(subject);
            }
            public override string ToString()
            {
                return name + " " + id + " " + gpa + " " + faculty;
            }
        }
        public class Subject
        {
            public string name;
            public string id;
            public string teacher;
            public Subject(string name, string id, string teacher)
            {
                    this.name = name;
                    this.id = id;
                    this.teacher = teacher;
            }

        }
            static void Main(string[] args)
            {
                string name = Console.ReadLine();
                string id = Console.ReadLine();
                double gpa = Double.Parse(Console.ReadLine());
                string faculty = Console.ReadLine();
                Student st1 = new Student(name, id, gpa, faculty);
                int n = 5;
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("name");
                    string s1 = Console.ReadLine();
                    Console.WriteLine("id");
                    string s2 = Console.ReadLine();
                    Console.WriteLine("teacher");
                    string s3 = Console.ReadLine();
                    string sb = s1 + " " + s2 + " "
                    st1.add_subject(sb);
                }
            }
            
       }
  } 
