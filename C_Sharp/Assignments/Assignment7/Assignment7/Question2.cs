using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    internal class Question2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter words separated by space:");
            string input = Console.ReadLine();

            string[] words = input.Split(' ');

            var result = from word in words
                         where word.StartsWith("a") && word.EndsWith("m")
                         select word;

            Console.WriteLine("Matching words:");

            foreach (var w in result)
            {
                Console.WriteLine(w);
            }

            Console.ReadLine();
        }
    }
}
