using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Question6
    {
       public  static void Length()
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            int length = word.Length;

            Console.WriteLine("Length of the word: " + length);
        }
    }
}
