using CodeChallenge4.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge4.BL
{
    public  class DistanceBL
    {
        private readonly IDistance _distance;

        public DistanceBL(IDistance distance)
        {
            _distance = distance;
        }

        public void Calculate()
        {
            Console.Write("Enter Distance 1: ");
            int d1 = int.Parse(Console.ReadLine());

            Console.Write("Enter Distance 2: ");
            int d2 = int.Parse(Console.ReadLine());

            int result = _distance.Add(d1, d2);

            Console.WriteLine("Total Distance: " + result + " km");
        }
    }
}
