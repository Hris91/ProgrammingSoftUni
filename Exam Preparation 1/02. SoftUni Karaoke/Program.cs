using System;
using System.Collections.Generic;
using System.Linq;


namespace _02.SoftUni_Karaoke
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> winners = new Dictionary<string, List<string>>();

            string[] participants = Console.ReadLine()
                .Split(new string[] {", "},StringSplitOptions.RemoveEmptyEntries);
            string[] avaliableSongs = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            string input = Console.ReadLine();

            while (input != "dawn")
            {
                string[] tokens = input
                    .Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries);
                                     
                AddToWinners(tokens, winners, participants, avaliableSongs);

                input = Console.ReadLine();
            }

            winners = winners
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            if (winners.Keys.Count != 0)
            {
                foreach (var winner in winners)
                {
                    if (winners.Values.Count != 0)
                    {
                        Console.WriteLine($"{winner.Key}: {winner.Value.Count} awards");
                        foreach (var award in winner.Value.OrderBy(a => a))
                        {
                            Console.WriteLine($"--{award}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No awards");
                    }
                }
            }

            else
            {
                Console.WriteLine("No awards");
            }          
        }

        private static void AddToWinners
            (string[] tokens, Dictionary<string, List<string>> winners, string[] participants, string[] avaliableSongs)
        {
            string currentParticipant = tokens[0];
            string currentSong = tokens[1];
            string currentAward = tokens[2];
           
            if (participants.Contains(currentParticipant) && avaliableSongs.Contains(currentSong))
            {
                if (!winners.ContainsKey(currentParticipant))
                {
                    winners[currentParticipant] = new List<string>();            
                }
                if (!winners[currentParticipant].Contains(currentAward))
                {
                    winners[currentParticipant].Add(currentAward);
                }                            
            }
        }
    }
}
