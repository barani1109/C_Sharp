using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Question3
    {
      public static void AvgMinMax()
        {
            int[] arr = { 10, 20, 30, 40, 50 };

            int sum = 0;
            int min = arr[0];
            int max = arr[0];

            foreach (int num in arr)
            {
                sum += num;

                if (num < min)
                    min = num;

                if (num > max)
                    max = num;
            }

            double average = (double)sum / arr.Length;

            Console.WriteLine("Array elements: " + string.Join(", ", arr));
            Console.WriteLine("Average value: " + average);
            Console.WriteLine("Minimum value: " + min);
            Console.WriteLine("Maximum value: " + max);
        }
    }
}
