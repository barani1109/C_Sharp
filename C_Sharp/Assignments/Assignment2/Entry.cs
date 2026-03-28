using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Entry
    {
        static void Main(string[] args)
        {
            Console.WriteLine("display the numbers");
            Question1.Display();
            Console.WriteLine("display the name of the day as a word");
            Question2.Days();
            Console.WriteLine("Average,Minimum and Maximum value in an array");
            Question3.AvgMinMax();
            Console.WriteLine("Accepts 10 marks and performs all the required operations");
            Question4.TenMark();
            Console.WriteLine("Copies elements from one array to another");
            Question5.CopyArray();
            Console.WriteLine("Length of the Word");
            Question6.Length();
            Console.WriteLine("Reverse a word");
            Question7.Reverse();
            Console.WriteLine("Compare two words");
            Question8.Compare();

        }
    }
}
