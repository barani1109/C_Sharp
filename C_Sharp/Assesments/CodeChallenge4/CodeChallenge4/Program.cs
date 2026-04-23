using System;
using CodeChallenge4.BL;

namespace CodeChallenge4
{
    public class Program
    {
        static void Main(string[] args)   // ✅ Entry point
        {
            DistanceBL obj = UnityResolver.DIInjector();  // ✅ inside Main

            obj.Calculate();   // ✅ works

            Console.ReadLine();
        }
    }
}