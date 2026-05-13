using System;
using System.Data;
using System.Data.SqlClient;

namespace CodeChallenge2
{
    // Business Layer
    class Employee
    {
        public int Empno { get; set; }

        DataAccess access = new DataAccess();

        // Update Salary
        public void UpdateSalary()
        {
            Console.WriteLine("Enter Employee ID :");
            Empno = Convert.ToInt32(Console.ReadLine());

            decimal updatedSalary =
                access.UpdateEmployeeSalary(Empno);

            if (updatedSalary > 0)
            {
                Console.WriteLine(
                    "Updated Salary : " + updatedSalary);
            }
            else
            {
                Console.WriteLine("Employee ID Not Found");
            }
        }

        // Display All Records
        public SqlDataReader DisplayRecords()
        {
            return access.GetEmployees();
        }
    }

    // Data Layer
    class DataAccess
    {
        static SqlConnection con = null;
        static SqlCommand cmd = null;
        static SqlDataReader dr = null;

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

        // Update Salary Procedure
        public decimal UpdateEmployeeSalary(int empid)
        {
            decimal salary = 0;

            try
            {
                con = GetConnection();

                cmd = new SqlCommand("sp_UpdateSalary", con);
                cmd.CommandType = CommandType.StoredProcedure;

                // Input parameter
                cmd.Parameters.AddWithValue("@empid", empid);

                // Output parameter
                cmd.Parameters.Add("@UpdatedSalary", SqlDbType.Decimal);
                cmd.Parameters["@UpdatedSalary"].Direction = ParameterDirection.Output;
                cmd.Parameters["@UpdatedSalary"].Precision = 10;
                cmd.Parameters["@UpdatedSalary"].Scale = 2;

                cmd.ExecuteNonQuery();

                if (cmd.Parameters["@UpdatedSalary"].Value != DBNull.Value)
                {
                    salary = Convert.ToDecimal(cmd.Parameters["@UpdatedSalary"].Value);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return salary;
        }

        // Display All Employees
        public SqlDataReader GetEmployees()
        {
            con = GetConnection();

            cmd = new SqlCommand(
                "SELECT * FROM Employee_Details",
                con);

            dr = cmd.ExecuteReader();

            return dr;
        }
    }

    // Client
    internal class Question2
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();

            Console.WriteLine(
                "------ Update Salary ------");

            emp.UpdateSalary();

            Console.WriteLine(
                "\n------ Employee Records ------");

            SqlDataReader dr =
                emp.DisplayRecords();

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