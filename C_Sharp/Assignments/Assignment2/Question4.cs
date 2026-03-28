using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Question4
    {
       public static void TenMark()
        {
            int[] marks = new int[10];
            int sum = 0;

            Console.WriteLine("Enter 10 marks:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Mark " + (i + 1) + ": ");
                marks[i] = Convert.ToInt32(Console.ReadLine());
                sum += marks[i];
            }

            double average = (double)sum / marks.Length;

            int min = marks[0];
            int max = marks[0];

            foreach (int m in marks)
            {
                if (m < min)
                    min = m;
                if (m > max)
                    max = m;
            }

            int[] asc = (int[])marks.Clone();
            Array.Sort(asc);

            int[] desc = (int[])marks.Clone();
            Array.Sort(desc);
            Array.Reverse(desc);

            Console.WriteLine("\nTotal: " + sum);
            Console.WriteLine("Average: " + average);
            Console.WriteLine("Minimum marks: " + min);
            Console.WriteLine("Maximum marks: " + max);

            Console.WriteLine("\nMarks in Ascending Order:");
            Console.WriteLine(string.Join(" ", asc));

            Console.WriteLine("\nMarks in Descending Order:");
            Console.WriteLine(string.Join(" ", desc));
        }
    }
}

