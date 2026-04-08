using System;

namespace CodeChallenge2
{
    
    delegate int Calculator(int a, int b);

    class Progr
    {
        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Subtract(int a, int b)
        {
            return a - b;
        }

        static int Multiply(int a, int b)
        {
            return a * b;
        }

        static void PerformOperation(int x, int y, Calculator calc, string operation)
        {
            int result = calc(x, y);
            Console.WriteLine($"{operation} Result: {result}");
        }

        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n--- Calculator Results ---\n");

            PerformOperation(num1, num2, Add, "Addition");
            PerformOperation(num1, num2, Subtract, "Subtraction");
            PerformOperation(num1, num2, Multiply, "Multiplication");

            Console.ReadLine();
        }
    }
}