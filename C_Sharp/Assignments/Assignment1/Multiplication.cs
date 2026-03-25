using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Multiplication
    {
        public static void Multiply()
        {
            int num;

            Console.Write("Enter the number: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(num + " * " + i + " = " + (num * i));
            }
        }
    }
}
