using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcasting_и_Downcasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person person;//при Upcasting
            Person person = new Mentor("Джим", 5);
           // Mentor mentor = new Mentor("Том", 8);
           // Student student = new Student("Джим", 5);
            //Student student;//Upcasting
           // student = (Student)person; //DownCasting

            //if(person is Student student) //соответсвие типов
            //{
            //    student = (Student)person;
            //    student.ShowName();
            //    Console.WriteLine(student.AverageScore);
            //}
            switch (person) 
            {
                case Mentor mentor:
                    mentor.ShowName();
                    Console.WriteLine(mentor.NumberOfStudents+" !");
                    break;
                case Student student:
                    student.ShowName();
                    Console.WriteLine(student.AverageScore);
                    break;
            }
        }
    }
    class Person
    {
        public string Name { get; private set; }

        public Person(string name)
        {
            Name = name;
        }
        public void ShowName()
        {
            Console.WriteLine($"Я - {Name}");
        }
    }
    class Mentor : Person
    {
        public int NumberOfStudents { get; private set; }
        public Mentor(string name, int numberOfStudents) : base(name)
        {
            NumberOfStudents = numberOfStudents;
        }
    }
    class Student : Person
    {
        public int AverageScore { get; private set; }
        public Student(string name, int averageScore) : base(name)
        {
            AverageScore = averageScore;
        }
    }
}
