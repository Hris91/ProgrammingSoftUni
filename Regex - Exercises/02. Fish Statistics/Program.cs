using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02.Fish_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex regex = new Regex(@"(>*)<(\(+)([\'\-x])>");
            List<Fish> fishList = new List<Fish>();

            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                string fish = match.Value;
                int tail = match.Groups[1].Length;
                int tailInCm = tail * 2;
                int body = match.Groups[2].Length;
                int bodyInCm = body * 2;
                string eyes = match.Groups[3].ToString();
                string fishStatus = string.Empty;
                string tailType = string.Empty;
                string bodyType = string.Empty;

                if (eyes == "'")
                {
                    fishStatus = "Awake";
                }
                else if(eyes == "-")
                {
                    fishStatus = "Asleep";
                }
                else if (eyes == "x")
                {
                    fishStatus = "Dead";
                }
               
                if (tail > 5)
                {
                    tailType = "Long";
                }
                else if (tail > 1 && tail <= 5)
                {
                    tailType = "Medium";
                }
                else if (tail == 1)
                {
                    tailType = "Short";
                }
                else if (tail == 0)
                {
                    tailType = "None";
                }

                if (body > 10)
                {
                    bodyType = "Long";
                }
                else if (body > 5 && body <= 10)
                {
                    bodyType = "Medium";
                }
                else
                {
                    bodyType = "Short";
                }
                Fish currentFish = new Fish();
                currentFish = currentFish.CreateFish(fish, tailInCm, bodyInCm, fishStatus, tailType, bodyType);
                fishList.Add(currentFish);

            }
            int fishCounter = 1;

            if (fishList.Count > 0)
            {
                foreach (var fish in fishList)
                {

                    Console.WriteLine($"Fish {fishCounter}: {fish.FishLooks}");

                    if (fish.TailType != "None")
                    {
                        Console.WriteLine($"  Tail type: {fish.TailType} ({fish.TailLength} cm)");
                    }
                    else
                    {
                        Console.WriteLine($"  Tail type: {fish.TailType}");
                    }

                    Console.WriteLine($"  Body type: {fish.BodyType} ({fish.BodyLength} cm)");
                    Console.WriteLine($"  Status: {fish.Status}");
                    fishCounter++;

                }
            }
            else
            {
                Console.WriteLine("No fish found.");
            }
          
        }
    }
}
