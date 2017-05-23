using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;


namespace _04.Worms_World_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, Dictionary<string, long>> teams = new Dictionary<string, Dictionary<string, long>>();
            
            while (input != "quit")
            {
                string[] tokens = input.Split(new[] {" -> "}, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string currentWormName = tokens[0];
                string currentTeamName = tokens[1];
                long score = long.Parse(tokens[2]);              

                if (!teams.ContainsKey(currentTeamName))
                {
                    teams[currentTeamName] = new Dictionary<string, long>();
                }
                bool isThereSuchWorm = false;

                foreach (var team in teams)
                {
                    foreach (var worm in team.Value)
                    {
                        if (worm.Key == currentWormName)
                        {
                            isThereSuchWorm = true;
                        }
                    }
                }
                if (!isThereSuchWorm)
                {
                    teams[currentTeamName][currentWormName] = score;
                }
               

                input = Console.ReadLine();
            }
            int counter = 1;

            try
            {
                teams = teams
                .OrderByDescending(x => x.Value.Values.Sum())
                .ThenByDescending(x => x.Value.Values.Sum() == 0 || x.Value.Keys.Count == 0 ? 0 : x.Value.Values.Sum() / x.Value.Keys.Count)
                .ThenBy(x => x.Value.Keys)
                .ToDictionary(x => x.Key, y => y.Value);
            }
            catch (Exception e)
            {

                teams = teams.OrderBy(x => x.Value.Keys.Count).ToDictionary(x => x.Key, y => y.Value); 


            }

            

           
            foreach (var team in teams)
            {
                BigInteger teamTotalScore = 0;

                foreach (var worm in team.Value)
                {
                    teamTotalScore += worm.Value;
                }
                Console.WriteLine($"{counter}. Team: {team.Key} - {teamTotalScore}");

                foreach (var worm in team.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"###{worm.Key} : {worm.Value}");
                }
                counter++;
            }
        }
    }
}
