using System;

namespace Assignment_3
{
    class Student
    {
        protected int rollNo;
        protected string name;
        protected string studentClass;
        protected int semester;
        protected string branch;

       
        public Student(int rNo, string sName, string sClass, int sem, string br)
        {
            rollNo = rNo;
            name = sName;
            studentClass = sClass;
            semester = sem;
            branch = br;
        }

        public void DisplayData()
        {
            Console.WriteLine("\n--- Student Details ---");
            Console.WriteLine("Roll No: " + rollNo);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Class: " + studentClass);
            Console.WriteLine("Semester: " + semester);
            Console.WriteLine("Branch: " + branch);
        }
    }

    class Result : Student
    {
        private int[] marks = new int[5];

        public Result(int rNo, string sName, string sClass, int sem, string br)
            : base(rNo, sName, sClass, sem, br)
        {
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
                    fail = true;

                total += marks[i];
            }

            double avg = total / 5.0;

            Console.WriteLine("\nAverage: " + avg);

            if (fail)
            {
                Console.WriteLine("Result: Failed (Subject < 35)");
            }
            else if (avg < 50)
            {
                Console.WriteLine("Result: Failed (Average < 50)");
            }
            else
            {
                Console.WriteLine("Result: Passed");
            }
        }

        public void ShowFullData()
        {
            DisplayData();

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
            Result s = new Result(101, "Arun", "BCA", 3, "CS");

            s.GetMarks();
            s.ShowFullData();
            s.DisplayResult();

            Console.ReadLine();
        }
    }
}