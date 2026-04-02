using System;
using System.Collections.Generic;

namespace CodeChallenge1
{
    public class EmployeeStructure
    {

        List<Employee> empList = new List<Employee>();

        public void Run()
        {
            int choice;

            do
            {
                Console.WriteLine("\n===== Employee Management Menu =====");
                Console.WriteLine("1. Add New Employee");
                Console.WriteLine("2. View All Employees");
                Console.WriteLine("3. Search Employee by ID");
                Console.WriteLine("4. Update Employee Details");
                Console.WriteLine("5. Delete Employee");
                Console.WriteLine("6. Exit");
                Console.WriteLine("====================================");
                Console.Write("Enter your choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1: AddEmployee(); break;
                    case 2: ViewEmployees(); break;
                    case 3: SearchEmployee(); break;
                    case 4: UpdateEmployee(); break;
                    case 5: DeleteEmployee(); break;
                    case 6: Console.WriteLine("Exiting..."); break;
                    default: Console.WriteLine("Invalid choice!"); break;
                }

            } while (choice != 6);
        }

        void AddEmployee()
        {
            Employee emp = new Employee();

            Console.Write("Enter ID: ");
            emp.Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name: ");
            emp.Name = Console.ReadLine();

            Console.Write("Enter Department: ");
            emp.Department = Console.ReadLine();

            Console.Write("Enter Salary: ");
            emp.Salary = Convert.ToDouble(Console.ReadLine());

            empList.Add(emp);
            Console.WriteLine("Employee added!");
        }

        void ViewEmployees()
        {
            if (empList.Count == 0)
            {
                Console.WriteLine("No employees found!");
                return;
            }

            foreach (var emp in empList)
            {
                emp.Display();
            }
        }

        void SearchEmployee()
        {
            Console.Write("Enter ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            var emp = empList.Find(e => e.Id == id);

            if (emp != null)
                emp.Display();
            else
                Console.WriteLine("Not found!");
        }

        void UpdateEmployee()
        {
            Console.Write("Enter ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            var emp = empList.Find(e => e.Id == id);

            if (emp != null)
            {
                Console.Write("New Name: ");
                emp.Name = Console.ReadLine();

                Console.Write("New Department: ");
                emp.Department = Console.ReadLine();

                Console.Write("New Salary: ");
                emp.Salary = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Updated!");
            }
            else
            {
                Console.WriteLine("Not found!");
            }
        }

        void DeleteEmployee()
        {
            Console.Write("Enter ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            var emp = empList.Find(e => e.Id == id);

            if (emp != null)
            {
                empList.Remove(emp);
                Console.WriteLine("Deleted!");
            }
            else
            {
                Console.WriteLine("Not found!");
            }
        }
    }
}