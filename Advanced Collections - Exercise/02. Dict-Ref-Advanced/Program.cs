using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Dict_Ref_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictRef = new Dictionary<string, List<int>>();
            string line = Console.ReadLine();

            while (line != "end")
            {
                string[] tokens =
                    line.Split(new[] {' ', '-', '>', ','}, StringSplitOptions.RemoveEmptyEntries).ToArray();

                List<int> numbers = new List<int>();

                string name = tokens[0];
                string secondName = string.Empty;

                int parsed = 0;

                if (int.TryParse(tokens[1],out parsed))
                {
                    for (int i = 1; i < tokens.Length; i++)
                    {
                        numbers.Add(int.Parse(tokens[i]));
                    }
                    AddnumbersToName(name, numbers, dictRef);
                }
                else
                {
                    secondName = tokens[1];

                    if (dictRef.ContainsKey(secondName))
                    {
                        dictRef[name] = new List<int>(dictRef[secondName]);                       
                    }
                }

                line = Console.ReadLine();
            }

            foreach (var ktp in dictRef)
            {
                Console.WriteLine($"{ktp.Key} === {string.Join(", ",ktp.Value)}");
            }        
        }

        private static void AddnumbersToName(string name, List<int> numbers, Dictionary<string, List<int>> dictRef)
        {
            if (!dictRef.ContainsKey(name))
            {
                dictRef[name] = new List<int>();
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                dictRef[name].Add(numbers[i]);
            }
        }
    }
}
