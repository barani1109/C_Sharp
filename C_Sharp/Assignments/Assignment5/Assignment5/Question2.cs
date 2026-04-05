using System;

namespace Assignment5
{
    public class InvalidMarksException : ApplicationException
    {
        public InvalidMarksException(string msg) : base(msg) { }
    }

    class Scholarship
    {
        public double Merit(int marks, double fees)
        {
            double amount = 0;

            if (marks >= 70 && marks <= 80)
            {
                amount = fees * 0.20;
            }
            else if (marks > 80 && marks <= 90)
            {
                amount = fees * 0.30;
            }
            else if (marks > 90)
            {
                amount = fees * 0.50;
            }
            else
            {
                throw new InvalidMarksException("Marks not eligible for scholarship!");
            }

            return amount;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Scholarship obj = new Scholarship();

            try
            {
                Console.Write("Enter Marks: ");
                int marks = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Fees: ");
                double fees = Convert.ToDouble(Console.ReadLine());

                double result = obj.Merit(marks, fees);

                Console.WriteLine("Scholarship Amount: " + result);
            }
            catch (InvalidMarksException ex)
            {
                Console.WriteLine("Custom Exception: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Process Completed.");
            }

            Console.ReadLine();
        }
    }
}