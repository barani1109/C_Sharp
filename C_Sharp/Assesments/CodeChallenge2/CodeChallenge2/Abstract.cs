using System;

namespace CodeChallenge2
{
    abstract class Student
    {
        public string Name { get; set; }
        public int StudentId { get; set; }
        public double Grade { get; set; }

        public Student(string name, int id, double grade)
        {
            Name = name;
            StudentId = id;
            Grade = grade;
        }

        public abstract bool IsPassed(double grade);
    }

    class Undergraduate : Student
    {
        public Undergraduate(string name, int id, double grade)
            : base(name, id, grade) { }

        public override bool IsPassed(double grade)
        {
            return grade > 70.0;
        }
    }

    class Graduate : Student
    {
        public Graduate(string name, int id, double grade)
            : base(name, id, grade) { }

        public override bool IsPassed(double grade)
        {
            return grade > 80.0;
        }
    }

    internal class Abstract
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Undergraduate Details:");
            Console.Write("Name: ");
            string name1 = Console.ReadLine();

            Console.Write("Student ID: ");
            int id1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Grade: ");
            double grade1 = Convert.ToDouble(Console.ReadLine());

            Undergraduate ug = new Undergraduate(name1, id1, grade1);

            Console.WriteLine();

            Console.WriteLine("Enter Graduate Details:");
            Console.Write("Name: ");
            string name2 = Console.ReadLine();

            Console.Write("Student ID: ");
            int id2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Grade: ");
            double grade2 = Convert.ToDouble(Console.ReadLine());

            Graduate g = new Graduate(name2, id2, grade2);

            Console.WriteLine("\n--- Results ---\n");

            Console.WriteLine("Undergraduate Student:");
            Console.WriteLine("Name: " + ug.Name);
            Console.WriteLine("ID: " + ug.StudentId);
            Console.WriteLine("Grade: " + ug.Grade);
            Console.WriteLine("Passed: " + ug.IsPassed(ug.Grade));

            Console.WriteLine();

            Console.WriteLine("Graduate Student:");
            Console.WriteLine("Name: " + g.Name);
            Console.WriteLine("ID: " + g.StudentId);
            Console.WriteLine("Grade: " + g.Grade);
            Console.WriteLine("Passed: " + g.IsPassed(g.Grade));

            Console.ReadLine();
        }
    }
}