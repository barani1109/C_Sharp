using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Operators
    {
        public static void Calculator()
        {
            double num1, num2;
            char operation;

            Console.Write("Input first number: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input operation (+, -, *, /): ");
            operation = Convert.ToChar(Console.ReadLine());

            Console.Write("Input second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            double result;

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    Console.WriteLine(num1 + " + " + num2 + " = " + result);
                    break;

                case '-':
                    result = num1 - num2;
                    Console.WriteLine(num1 + " - " + num2 + " = " + result);
                    break;

                case '*':
                    result = num1 * num2;
                    Console.WriteLine(num1 + " * " + num2 + " = " + result);
                    break;

                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine(num1 + " / " + num2 + " = " + result);
                    }
                    else
                    {
                        Console.WriteLine("Division by zero is not allowed.");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid operation.");
                    break;
            }
        }
    }
}
