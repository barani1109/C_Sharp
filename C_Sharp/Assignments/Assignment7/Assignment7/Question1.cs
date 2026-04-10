using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment7
{
    internal class Question1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers separated by space:");
            string input = Console.ReadLine();

            string[] values = input.Split(' ');
            List<int> numbers = new List<int>();

            foreach (string val in values)
            {
                numbers.Add(int.Parse(val));
            }

            var result = numbers
                         .Select(n => new { Number = n, Square = n * n })
                         .Where(x => x.Square > 20);

            if (!result.Any())
            {
                Console.WriteLine("No numbers found with square greater than 20");
            }
            else
            {
                Console.WriteLine("Numbers with square greater than 20:");
                foreach (var item in result)
                {
                    Console.WriteLine($"{item.Number} - {item.Square}");
                }
            }

            Console.ReadLine();
        }
    }
}