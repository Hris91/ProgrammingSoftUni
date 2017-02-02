using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Traveling_At_Light_Speed
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal lighYears = decimal.Parse(Console.ReadLine());
            decimal lightYearsInKillometers = lighYears * 9450000000000m;
            uint secondsInHour = 60 * 60;
            uint secondsInDay = secondsInHour * 24;
            uint secondsInWeek = secondsInDay * 7;
            
            decimal totalSeconds = lightYearsInKillometers / 300000;
            decimal weeks = Math.Floor(totalSeconds / secondsInWeek);
            totalSeconds = totalSeconds % secondsInWeek;
            decimal days =Math.Floor(totalSeconds / secondsInDay);
            totalSeconds = totalSeconds % secondsInDay;
            decimal hours = Math.Floor(totalSeconds / secondsInHour);
            totalSeconds = totalSeconds % secondsInHour;
            decimal minutes =Math.Floor (totalSeconds / 60);
            totalSeconds = totalSeconds % 60;
            decimal seconds = totalSeconds % 60;

            Console.WriteLine($"{Math.Round(weeks)} weeks");
            Console.WriteLine($"{Math.Round(days)} days");
            Console.WriteLine($"{Math.Round(hours)} hours");
            Console.WriteLine($"{Math.Round(minutes)} minutes");
            Console.WriteLine($"{Math.Round(seconds)} seconds");

        }
    }
}
