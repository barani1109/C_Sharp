using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class PositiveOrNegative
    {
        public  static void IsPositiveOrNegative()
        {
            int num;
            Console.Write("Input a number: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine(num + "is a positive number");
            }
            else if (num < 0)
            {
                Console.WriteLine(num + "is a negative number");
            }
            else
            {
                Console.WriteLine("The number is zero");
            }

        }
    }
}
