using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Happiness_Index
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex happyPattern = new Regex(@"([;:]{1}[)D*\]}]{1})|([(*\[c]{1}[;:]{1})");
            Regex sadPattern = new Regex(@"([;:]{1})[([{c]{1}|([D)\]]{1})([;:]{1})");

            string input = Console.ReadLine();

            MatchCollection happyCollection = happyPattern.Matches(input);
            MatchCollection sadCollection = sadPattern.Matches(input);

            decimal happyCount = happyCollection.Count;
            decimal sadCount = sadCollection.Count;

            decimal happinessIndex = happyCount / sadCount;

            string emoticon = string.Empty;

            if (happinessIndex >= 2)
            {
                emoticon = ":D";
            }
            else if (happinessIndex > 1 && happinessIndex < 2)
            {
                emoticon = ":)";
            }
            else if(happinessIndex == 1)
            {
                emoticon = ":|";
            }
            else if(happinessIndex < 1)
            {
                emoticon = ":(";
            }

            Console.WriteLine($"Happiness index: {happinessIndex:f2} {emoticon}");
            Console.WriteLine($"[Happy count: {happyCount}, Sad count: {sadCount}]");
        }
    }
}
