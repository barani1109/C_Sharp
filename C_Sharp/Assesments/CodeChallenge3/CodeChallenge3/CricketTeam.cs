using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge3
{
    internal class CricketTeam
    {
        public string TeamName { get; set; }

        public CricketTeam(string teamName)
        {
            TeamName = teamName;
        }

        public (int count, double average, int sum) Pointscalculation(int no_of_matches)
        {
            int sum = 0;

            Console.WriteLine($"\nEnter scores for {TeamName}:");

            for (int i = 1; i <= no_of_matches; i++)
            {
                Console.Write($"  Match {i} score: ");
                int score = int.Parse(Console.ReadLine());
                sum += score;
            }

            double average = (double)sum / no_of_matches;

            return (no_of_matches, average, sum);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------IPL Points Calculator ---------\n");

            Console.Write("Enter Team Name: ");
            string teamName = Console.ReadLine();

            Console.Write("Enter Number of Matches Played: ");
            int no_of_matches = int.Parse(Console.ReadLine());

            CricketTeam team = new CricketTeam(teamName);

            var (count, average, sum) = team.Pointscalculation(no_of_matches);

            Console.WriteLine("\n---------- Results ------------");
            Console.WriteLine($"  Team Name     : {team.TeamName}");
            Console.WriteLine($"  Match Count   : {count}");
            Console.WriteLine($"  Total Points  : {sum}");
            Console.WriteLine($"  Average Points: {average:F2}");
           
        }
    }
}