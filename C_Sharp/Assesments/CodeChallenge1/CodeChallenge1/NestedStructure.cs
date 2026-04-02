using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge1
{
    internal class NestedStructure
    {
        struct Employee
        {
            public string Name;

            public struct DOB
            {
                public int day;
                public int month;
                public int year;
            }

            public DOB dob; 
        }

        static void Main(string[] args)
        {
            GetEmployeeData();  

            Console.ReadLine();
        }

        static void GetEmployeeData()
        {
            Employee[] emp = new Employee[2];

            for (int i = 0; i < emp.Length; i++)
            {
                Console.Write("Name of the employee: ");
                emp[i].Name = Console.ReadLine();

                Console.Write("Input day of the birth: ");
                emp[i].dob.day = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input month of the birth: ");
                emp[i].dob.month = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input year for the birth: ");
                emp[i].dob.year = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
            }

            Console.WriteLine("\n--- Employee Details ---");

            for (int i = 0; i < emp.Length; i++)
            {
                Console.WriteLine("\nName: " + emp[i].Name);
                Console.WriteLine("DOB: " +
                    emp[i].dob.day + "/" +
                    emp[i].dob.month + "/" +
                    emp[i].dob.year);
            }
        }
    }
}