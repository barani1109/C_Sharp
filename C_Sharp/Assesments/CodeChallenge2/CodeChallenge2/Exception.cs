using System;

namespace CodeChallenge2
{
    internal class Progra
    {
        static void CheckNumber(int num)
        {
            if (num < 0)
            {
                throw new Exception("Number cannot be negative!");
            }

            Console.WriteLine("Number is valid: " + num);
        }

        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a number: ");
                int number = Convert.ToInt32(Console.ReadLine());

                CheckNumber(number);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught: " + ex.Message);
            }

            Console.ReadLine();
        }
    }
}