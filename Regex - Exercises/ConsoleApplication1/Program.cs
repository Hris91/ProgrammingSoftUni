using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string input = Console.ReadLine();

            Regex regex = new Regex(@"([1]?[0-9JQKA])([SHDC])");
            MatchCollection matches = regex.Matches(input);

            List<string> result = new List<string>();

            foreach (Match match in matches)
            {
                int power = 0;

                if (int.TryParse(match.Groups[1].Value, out power))
                {
                    if (power < 2 || power > 10)
                    {
                        continue;
                    }
                }
                
                result.Add(match.Value);
            }
            
            Console.WriteLine(string.Join(", ",result));
           
        }
    }
}
