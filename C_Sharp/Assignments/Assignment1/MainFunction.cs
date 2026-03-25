using System;

namespace Assignments
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Is num1,num2 Equal or Not");
            EqualOrNot.IsEqualOrNot();
            Console.WriteLine("Is given integer positive or not");
            PositiveOrNegative.IsPositiveOrNegative();
            Console.WriteLine("Calculator");
            Operators.Calculator();
            Console.WriteLine("Multiplication Table");
            Multiplication.Multiply();
            Console.WriteLine("Sum of two numbers with triplet sum condition");
            SumOfTwoNum.SumOfTwoNumbers();
        }
     
    }
}
