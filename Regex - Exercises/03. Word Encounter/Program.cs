using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Word_Encounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string filter = Console.ReadLine();

            string line = Console.ReadLine();

            List<string> validWords = new List<string>();

            while (line != "end")
            {
                string[] tokens = line.Split(new[] {' ', ',', ';', ':'}, StringSplitOptions.RemoveEmptyEntries);

                string patternForCapitalLetter = @"[A-Z]{1}";
                string patternFoeEndOFSentance = @"[!\.\?]";

                string firstWord = tokens[0];
                string lastWord = tokens[tokens.Length - 1];

                Regex forCapitalLetter = new Regex(patternForCapitalLetter);
                Regex forEndOfSentance = new Regex(patternFoeEndOFSentance);

                bool hasCapitalLetter = forCapitalLetter.IsMatch(firstWord);
                bool endsProperly = forEndOfSentance.IsMatch(lastWord);

                if (hasCapitalLetter && endsProperly)
                {
                    string filterCharacter = filter.Substring(0, 1);
                    int filterTimes = int.Parse(filter.Substring(1, 1));
                                   
                    foreach (var token in tokens)
                    {
                        int count = token.Count(p => p == filterCharacter.ToCharArray().First());

                        if (count >= filterTimes)
                        {
                            validWords.Add(token.Trim('.','!',',','?',':',';'));
                        }                     
                    }           
                }
                line = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", validWords));

            
        }
    }
}
