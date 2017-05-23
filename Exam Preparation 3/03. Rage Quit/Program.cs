using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


namespace _03.Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToUpper();
            char[] unique = input.ToCharArray();

            unique = unique
                .Where(p => !Char.IsDigit(p))
                .Distinct()
                .ToArray();

            Regex rageRegex = new Regex(@"([^0-9]+)([0-9]+)");
            MatchCollection matches = rageRegex.Matches(input);

            StringBuilder builder = new StringBuilder();

            foreach (Match match in matches)
            {
                int repeatTimes = int.Parse(match.Groups[2].ToString());

                for (int i = 0; i < repeatTimes; i++)
                {
                    builder = builder.Append(match.Groups[1]);
                }
             
            }
            Console.WriteLine($"Unique symbols used: {unique.Length}");
            Console.WriteLine(builder.ToString());


        }
    }
}
