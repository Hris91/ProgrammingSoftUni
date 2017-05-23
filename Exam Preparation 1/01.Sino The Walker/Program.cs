using System;
using System.Globalization;
using System.Numerics;
namespace _01.Sino_The_Walker
{
    class Program
    {
        static void Main(string[] args)
        {
            string dateAsString = Console.ReadLine();
            TimeSpan timeHeLeaves = TimeSpan.ParseExact(dateAsString, @"hh\:mm\:ss", CultureInfo.InvariantCulture);

            int stepsTaken = int.Parse(Console.ReadLine());
            int secondsPerStep = int.Parse(Console.ReadLine());
          
            int secondsPerDay = 60 * 60 * 24;
            var totalSecondsNeeded = (int)(((double)stepsTaken * secondsPerStep) % secondsPerDay);

            timeHeLeaves = timeHeLeaves.Add(new TimeSpan(0, 0, totalSecondsNeeded));
            string timeToString = timeHeLeaves.ToString(@"hh\:mm\:ss");
            

            Console.WriteLine($"Time Arrival: {timeToString}");

        }
    }
}
