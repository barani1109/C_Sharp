using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class SumOfTwoNum
    {
        public static  void SumOfTwoNumbers()
        {
            int num1, num2, result;
            Console.Write("Input first integer: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input second integer: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2)
            {
                result = (num1 + num2) * 3;
            }
            else
            {
                result = num1 + num2;
            }
            Console.WriteLine("Result: " + result);
        }
    }
}
