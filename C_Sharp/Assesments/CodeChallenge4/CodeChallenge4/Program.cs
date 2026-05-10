using System;
using CodeChallenge4.BL;

namespace CodeChallenge4
{
    public class Program
    {
        static void Main(string[] args) 
        {
            DistanceBL obj = UnityResolver.DIInjector(); 

            obj.Calculate(); 

            Console.ReadLine();
        }
    }
}