using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public int EmpId { get; set; }
    public string EmpName { get; set; }
    public string EmpCity { get; set; }
    public double EmpSalary { get; set; }
}

class Question3
{
    public 
        static void Main()
    {
        List<Employee> employees = new List<Employee>()
        {
            new Employee { EmpId = 1, EmpName = "Arun", EmpCity = "Bangalore", EmpSalary = 50000 },
            new Employee { EmpId = 2, EmpName = "Bala", EmpCity = "Chennai", EmpSalary = 40000 },
            new Employee { EmpId = 3, EmpName = "Amit", EmpCity = "Bangalore", EmpSalary = 60000 },
            new Employee { EmpId = 4, EmpName = "Divya", EmpCity = "Hyderabad", EmpSalary = 30000 },
            new Employee { EmpId = 5, EmpName = "Anu", EmpCity = "Bangalore", EmpSalary = 45000 }
        };

        Console.WriteLine("All Employees:");
        Display(employees);

        var highSalary = employees.Where(e => e.EmpSalary > 45000);
        Console.WriteLine("\nEmployees with Salary > 45000:");
        Display(highSalary);

        var bangaloreEmp = employees.Where(e => e.EmpCity == "Bangalore");
        Console.WriteLine("\nEmployees from Bangalore:");
        Display(bangaloreEmp);

        var sortedByName = employees.OrderBy(e => e.EmpName);
        Console.WriteLine("\nEmployees sorted by Name (Ascending):");
        Display(sortedByName);

        Console.ReadLine();
    }

    static void Display(IEnumerable<Employee> list)
    {
        foreach (var e in list)
        {
            Console.WriteLine($"{e.EmpId} | {e.EmpName} | {e.EmpCity} | {e.EmpSalary}");
        }
    }
}