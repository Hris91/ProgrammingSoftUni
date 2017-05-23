using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace _03.Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            string decryptionKey = Regex.Escape(Console.ReadLine());

            string pattern = $@".*{decryptionKey}([A-Za-z]*){decryptionKey}.*{decryptionKey}([A-Za-z]*){decryptionKey}";
            string resultPattern = @"\d+\s?:\s?\d+";

            

            SortedDictionary<string, long> teamPoints = new SortedDictionary<string, long>();
            SortedDictionary<string, long> teamGoals = new SortedDictionary<string, long>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "final")
                {
                    break;
                }
                Regex regex = new Regex(pattern);
                Regex resultRegex = new Regex(resultPattern);

                Match validMatch = regex.Match(input);
                Match resultMatch = resultRegex.Match(input);

                if (!validMatch.Success || !resultMatch.Success)
                {
                    continue;
                }

                char[] teamOneExtracted = validMatch.Groups[1].ToString().ToCharArray().Reverse().ToArray();
                string teamOneDecrypted = string.Join("",teamOneExtracted).ToUpper();

                char[] teamTwoExtracted = validMatch.Groups[2].ToString().ToCharArray().Reverse().ToArray();
                string teamTwoDecrypted = string.Join("", teamTwoExtracted).ToUpper();

                string[] goalsMatch = resultMatch.Groups[0].ToString().Split(':').ToArray();
                long goalsTeamOne = long.Parse(goalsMatch[0]);
                long goalsTeamTwo = long.Parse(goalsMatch[1]);

                if (!teamGoals.ContainsKey(teamOneDecrypted))
                {
                    teamGoals[teamOneDecrypted] = 0;
                }
                teamGoals[teamOneDecrypted] += goalsTeamOne;
                if (!teamGoals.ContainsKey(teamTwoDecrypted))
                {
                    teamGoals[teamTwoDecrypted] = 0;
                }
                teamGoals[teamTwoDecrypted] += goalsTeamTwo;

                if (!teamPoints.ContainsKey(teamOneDecrypted))
                {
                    teamPoints[teamOneDecrypted] = 0;
                }
                if (!teamPoints.ContainsKey(teamTwoDecrypted))
                {
                    teamPoints[teamTwoDecrypted] = 0;
                }
               
                if (goalsTeamOne > goalsTeamTwo)
                {
                    teamPoints[teamOneDecrypted] += 3;
                }
                else if (goalsTeamTwo > goalsTeamOne)
                {
                    teamPoints[teamTwoDecrypted] += 3;
                }
                else if (goalsTeamOne == goalsTeamTwo)
                {
                    teamPoints[teamOneDecrypted] += 1;
                    teamPoints[teamTwoDecrypted] += 1;
                }
                             
               
            }
            Dictionary<string, long> sortedTeamPoints= teamPoints.OrderByDescending(y => y.Value).ToDictionary(x => x.Key, y => y.Value);

            Console.WriteLine("League standings:");
            int counter = 1;

            foreach (var team in sortedTeamPoints)
            {
                Console.WriteLine($"{counter}. {team.Key} {team.Value}");
                counter++;
            }
            

            Dictionary<string, long> sortedGoals = teamGoals
                    .OrderByDescending(y => y.Value)
                    .Take(teamGoals.Count >= 3 ? 3 : teamGoals.Count)
                    .ToDictionary(x => x.Key, y => y.Value);

            Console.WriteLine("Top 3 scored goals:");
            foreach (var goal in sortedGoals)
            {
                Console.WriteLine($"- {goal.Key} -> {goal.Value}");
            }

        }
    }
}
