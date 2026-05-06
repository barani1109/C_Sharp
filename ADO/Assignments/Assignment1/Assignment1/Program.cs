using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment1
{
    class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string City { get; set; }
    }

    class EmployeeDetails
    {
        public static List<Employee> GetEmployees()
        {
            return new List<Employee>()
            {
                new Employee { EmployeeID=1001, FirstName="Malcolm", LastName="Daruwalla", Title="Manager", DOB=new DateTime(1984,11,16), DOJ=new DateTime(2011,6,8), City="Mumbai"},
                new Employee { EmployeeID=1002, FirstName="Asdin", LastName="Dhalla", Title="AsstManager", DOB=new DateTime(1984,8,20), DOJ=new DateTime(2012,7,7), City="Mumbai"},
                new Employee { EmployeeID=1003, FirstName="Madhavi", LastName="Oza", Title="Consultant", DOB=new DateTime(1987,11,14), DOJ=new DateTime(2015,4,12), City="Pune"},
                new Employee { EmployeeID=1004, FirstName="Saba", LastName="Shaikh", Title="SE", DOB=new DateTime(1990,6,3), DOJ=new DateTime(2016,2,2), City="Pune"},
                new Employee { EmployeeID=1005, FirstName="Nazia", LastName="Shaikh", Title="SE", DOB=new DateTime(1991,3,8), DOJ=new DateTime(2016,2,2), City="Mumbai"},
                new Employee { EmployeeID=1006, FirstName="Amit", LastName="Pathak", Title="Consultant", DOB=new DateTime(1989,11,7), DOJ=new DateTime(2014,8,8), City="Chennai"},
                new Employee { EmployeeID=1007, FirstName="Vijay", LastName="Natrajan", Title="Consultant", DOB=new DateTime(1989,12,2), DOJ=new DateTime(2015,6,1), City="Mumbai"},
                new Employee { EmployeeID=1008, FirstName="Rahul", LastName="Dubey", Title="Associate", DOB=new DateTime(1993,11,11), DOJ=new DateTime(2014,11,6), City="Chennai"},
                new Employee { EmployeeID=1009, FirstName="Suresh", LastName="Mistry", Title="Associate", DOB=new DateTime(1992,8,12), DOJ=new DateTime(2014,12,3), City="Chennai"},
                new Employee { EmployeeID=1010, FirstName="Sumit", LastName="Shah", Title="Manager", DOB=new DateTime(1991,4,12), DOJ=new DateTime(2016,1,2), City="Pune"}
            };
        }
    }

    internal class Program
    {
        static void Main()
        {
            var empList = EmployeeDetails.GetEmployees();

            var q1 = empList.Where(e => e.DOJ < new DateTime(2015, 1, 1));
            Console.WriteLine("1. Joined before 2015:");
            foreach (var e in q1)
                Console.WriteLine(e.FirstName);

            var q2 = empList.Where(e => e.DOB > new DateTime(1990, 1, 1));
            Console.WriteLine("\n2. DOB after 1990:");
            foreach (var e in q2)
                Console.WriteLine(e.FirstName);

            var q3 = empList.Where(e => e.Title == "Consultant" || e.Title == "Associate");
            Console.WriteLine("\n3. Consultant & Associate:");
            foreach (var e in q3)
                Console.WriteLine(e.FirstName);

            var totalEmp = empList.Count();
            Console.WriteLine($"\n4. Total Employees: {totalEmp}");

            var chennaiCount = empList.Count(e => e.City == "Chennai");
            Console.WriteLine($"5. Chennai Employees: {chennaiCount}");

            var maxId = empList.Max(e => e.EmployeeID);
            Console.WriteLine($"6. Highest Employee ID: {maxId}");

            var joinedAfter = empList.Count(e => e.DOJ > new DateTime(2015, 1, 1));
            Console.WriteLine($"7. Joined after 2015: {joinedAfter}");

            var notAssociate = empList.Count(e => e.Title != "Associate");
            Console.WriteLine($"8. Not Associate: {notAssociate}");

            var groupCity = empList.GroupBy(e => e.City)
                                   .Select(g => new { City = g.Key, Count = g.Count() });
            Console.WriteLine("\n9. Count by City:");
            foreach (var g in groupCity)
                Console.WriteLine($"{g.City} - {g.Count}");

            var groupCityTitle = empList.GroupBy(e => new { e.City, e.Title })
                                        .Select(g => new { g.Key.City, g.Key.Title, Count = g.Count() });
            Console.WriteLine("\n10. Count by City & Title:");
            foreach (var g in groupCityTitle)
                Console.WriteLine($"{g.City} - {g.Title} - {g.Count}");

            var youngest = empList.OrderByDescending(e => e.DOB).First();
            Console.WriteLine($"\n11. Youngest Employee: {youngest.FirstName}");


            Console.ReadLine();
        }
    }
}