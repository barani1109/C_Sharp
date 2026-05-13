using System;
using System.Data;
using System.Data.SqlClient;

namespace CodeChallenge1
{
    // Business Layer
    class Employee
    {
        public string EmpName { get; set; }
        public decimal EmpSal { get; set; }
        public char EmpType { get; set; }

        DataAccess access = new DataAccess();

        // Insert Employee
        public int AddEmployee()
        {
            Console.WriteLine("Enter Employee Name :");
            EmpName = Console.ReadLine();

            Console.WriteLine("Enter Employee Salary :");
            EmpSal = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter Employee Type (F/P) :");
            EmpType = Convert.ToChar(Console.ReadLine());

            return access.InsertEmployee(EmpName, EmpSal, EmpType);
        }

        // Display Employees
        public SqlDataReader ShowEmployees()
        {
            return access.GetEmployees();
        }
    }

    // Data Access Layer
    class DataAccess
    {
        static SqlConnection con = null;
        static SqlCommand cmd = null;
        static SqlDataReader dr = null;
        static int result;

        // Database Connection
        public SqlConnection GetConnection()
        {
            string str =
                "Data Source=(localdb)\\MSSQLLocalDB;" +
                "Initial Catalog=Employeemanagement;" +
                "Integrated Security=True";

            con = new SqlConnection(str);

            con.Open();

            return con;
        }

        // Insert using Stored Procedure
        public int InsertEmployee(string name, decimal sal, char type)
        {
            try
            {
                con = GetConnection();

                cmd = new SqlCommand("sp_InsertEmployee", con);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@EmpName", name);
                cmd.Parameters.AddWithValue("@Empsal", sal);
                cmd.Parameters.AddWithValue("@Emptype", type);

                result = cmd.ExecuteNonQuery();
            }

            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return result;
        }

        // Display Employees
        public SqlDataReader GetEmployees()
        {
            try
            {
                con = GetConnection();

                cmd = new SqlCommand(
                    "SELECT * FROM Employee_Details", con);

                dr = cmd.ExecuteReader();

                return dr;
            }

            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return dr;
        }
    }

    // Client
    internal class Question1
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();

            Console.WriteLine("------ Insert Employee ------");

            int res = emp.AddEmployee();

            if (res > 0)
            {
                Console.WriteLine("Employee Inserted Successfully");
            }
            else
            {
                Console.WriteLine("Insertion Failed");
            }

            Console.WriteLine("\n------ Employee Details ------");

            SqlDataReader dr = emp.ShowEmployees();

            while (dr.Read())
            {
                Console.WriteLine(
                    dr["Empno"] + " " +
                    dr["EmpName"] + " " +
                    dr["Empsal"] + " " +
                    dr["Emptype"]);
            }

            Console.ReadLine();
        }
    }
}