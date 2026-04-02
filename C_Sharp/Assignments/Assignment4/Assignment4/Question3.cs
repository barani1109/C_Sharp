using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Question3
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            Console.Write("Enter number of elements: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter element: ");
                int value = Convert.ToInt32(Console.ReadLine());
                stack.Push(value);
            }
            List<int> list = stack.ToList();
            list.Sort();
            list.Reverse(); 

            stack.Clear();
            for (int i = list.Count - 1; i >= 0; i--)
            {
                stack.Push(list[i]);
            }

            Console.WriteLine("\nStack elements in descending order:");
            foreach (int item in stack)
            {
                Console.Write(item + " ");
            }

            Console.ReadLine();
        }
    }
}
