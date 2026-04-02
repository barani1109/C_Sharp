using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Question1
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RemoveChar("Python", 1));
            Console.WriteLine(RemoveChar("Python", 0));
            Console.WriteLine(RemoveChar("Python", 4));

            Console.ReadLine();
        }
        static string RemoveChar(string str, int pos)
        {
            return str.Remove(pos, 1);
        }
    }
}
