using System;
using Travel;

namespace Assignment7
{
    class Question4
    {
        const double TotalFare = 500;

        static void Main()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Age: ");
            int age = int.Parse(Console.ReadLine());

            TravelConcession ticket = new TravelConcession();

            string result = ticket.CalculateConcession(age, TotalFare);

            Console.WriteLine($"\nHello {name}");
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}