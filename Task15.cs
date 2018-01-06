using System;

namespace Task15 
{
    public class Stud
  { 
    public class Student
    {
        public string Name;
        public int Course;
        public bool Stipendia;

        public Student(string name, int course)
        {
        this.Name = name;
        this.Course = course;
        }

        public Student(string name, bool stipendia)
        {
            this.Name = name;
            this.Stipendia = stipendia;
        }

        public Student()
        {
            this.Name = "Kevin";
            this.Stipendia = false;
            this.Course = 2;

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student first = new Student("Ivan", 2);
            Console.WriteLine();

            Student second = new Student("Alex",false);
            Console.WriteLine();

            Student third = new Student();
            Console.WriteLine();
        }
    }
  }
}
