using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Question5
    {
        public static void CopyArray()
        {
            int[] source = new int[5];
            int[] destination = new int[5];

            Console.WriteLine("Enter 5 elements:");
            for (int i = 0; i < source.Length; i++)
            {
                Console.Write("Element " + (i + 1) + ": ");
                source[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < source.Length; i++)
            {
                destination[i] = source[i];
            }

            Console.WriteLine("\nSource Array:");
            for (int i = 0; i < source.Length; i++)
            {
                Console.Write(source[i] + " ");
            }
            Console.WriteLine("\nDestination Array:");
            for (int i = 0; i < destination.Length; i++)
            {
                Console.Write(destination[i] + " ");
            }
        }
    }
}
