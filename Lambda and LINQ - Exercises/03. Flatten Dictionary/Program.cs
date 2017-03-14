using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Flatten_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var regularDictionary = new Dictionary<string, Dictionary<string, string>>();
            var sortedDictionary = new Dictionary<string, Dictionary<string, string>>();

            string line = Console.ReadLine();


            while (line != "end")
            {
                string[] tokens = line.Split(' ').ToArray();

                if (tokens[0] != "flatten")
                {
                    string mainKey = tokens[0];
                    string secondaryKey = tokens[1];
                    string inputValue = tokens[2];

                    AddToDictionary(mainKey, secondaryKey, inputValue, regularDictionary);
                }
                else
                {
                    string flattenKey = tokens[1];

                     regularDictionary[flattenKey] = regularDictionary[flattenKey]
                        .ToDictionary(p => p.Key + p.Value, p => "flattened");
                }

                line = Console.ReadLine();
            }
            sortedDictionary = regularDictionary
                .OrderByDescending(p => p.Key.Length)
                .ToDictionary(p => p.Key, p => p.Value);

            foreach (var ktp in sortedDictionary)
            {                
                Console.WriteLine($"{ktp.Key}");

                Dictionary<string, string> orderedInnerDictionary =
                    ktp.Value
                        .Where(p => p.Value != "flattened")
                        .OrderBy(p => p.Key.Length)
                        .ToDictionary(p => p.Key, p => p.Value);

                Dictionary<string, string> flattenedValues =
                    ktp.Value
                        .Where(p => p.Value == "flattened")
                        .ToDictionary(p => p.Key, p => p.Value);

                int counter = 1;
                foreach (var innerEntry in orderedInnerDictionary)
                {
                    
                    Console.WriteLine($"{counter}. {innerEntry.Key} - {innerEntry.Value}");
                    counter++;
                }
                foreach (var flatten in flattenedValues)
                {
                    Console.WriteLine($"{counter}. {flatten.Key}");
                    counter++;
                }

            }
            
        }

        private static void AddToDictionary(string mainKey, string secondaryKey,
            string inputValue, Dictionary<string, Dictionary<string, string>> regularDictionary)
        {
            if (!regularDictionary.ContainsKey(mainKey))
            {
                regularDictionary[mainKey] = new Dictionary<string, string>();
            }
           
            regularDictionary[mainKey][secondaryKey] = inputValue;
        }
    }
}
