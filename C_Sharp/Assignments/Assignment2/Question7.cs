using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Question7
    {
       public  static void Reverse()
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            char[] arr = word.ToCharArray();
            Array.Reverse(arr);
            string reversed = new string(arr);

            Console.WriteLine("Reversed word: " + reversed);
        }
    }
}
