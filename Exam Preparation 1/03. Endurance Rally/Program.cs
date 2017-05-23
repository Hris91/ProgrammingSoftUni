using System;
using System.Collections.Generic;
using System.Linq;


namespace _03.Endurance_Rally
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] racers = Console.ReadLine()
                .Split(' ');

            double[] raceTrack = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            int[] checkPoints = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            foreach (var racer in racers)
            {
                char[] toChar = racer.ToCharArray();
                double racerFuel = (double) toChar[0];

                for (int i = 0; i < raceTrack.Length; i++)
                {
                    int currentStep = i;
                    double currentPower = raceTrack[i];

                    bool isAtCheckPoint = checkPoints.Contains(currentStep);

                    if (isAtCheckPoint)
                    {
                        racerFuel += currentPower;
                    }
                    else
                    {
                        racerFuel -= currentPower;
                    }

                    isAtCheckPoint = false;

                    if (racerFuel <= 0)
                    {
                        Console.WriteLine($"{racer} - reached {i}");
                        break;
                    }                   
                }

                if (racerFuel <= 0)
                {
                    continue;
                }

                Console.WriteLine($"{racer} - fuel left {racerFuel:f2}");
            }
                   
        }
    }
}
