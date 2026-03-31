using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Student
    {
        private int rollNo;
        private string name;
        private string studentClass;
        private int semester;
        private string branch;
        private int[] marks = new int[5];

        public Student(int rNo, string sName, string sClass, int sem, string br)
        {
            rollNo = rNo;
            name = sName;
            studentClass = sClass;
            semester = sem;
            branch = br;
        }

        public void GetMarks()
        {
            Console.WriteLine("Enter marks for 5 subjects:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Subject " + (i + 1) + ": ");
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void DisplayResult()
        {
            int total = 0;
            bool fail = false;

            for (int i = 0; i < 5; i++)
            {
                if (marks[i] < 35)
                {
                    fail = true;
                }
                total += marks[i];
            }

            double average = total / 5.0;

            Console.WriteLine("\nAverage Marks: " + average);

            if (fail)
            {
                Console.WriteLine("Result: Failed (One or more subjects < 35)");
            }
            else if (average < 50)
            {
                Console.WriteLine("Result: Failed (Average < 50)");
            }
            else
            {
                Console.WriteLine("Result: Passed");
            }
        }

        public void DisplayData()
        {
            Console.WriteLine("\n--- Student Details ---");
            Console.WriteLine("Roll No: " + rollNo);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Class: " + studentClass);
            Console.WriteLine("Semester: " + semester);
            Console.WriteLine("Branch: " + branch);

            Console.WriteLine("Marks:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Subject " + (i + 1) + ": " + marks[i]);
            }
        }
    }

    internal class Question2
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(101, "Arun", "BCA", 3, "Computer Science");

            s1.GetMarks();
            s1.DisplayData();
            s1.DisplayResult();

            Console.ReadLine();
        }
    }
}