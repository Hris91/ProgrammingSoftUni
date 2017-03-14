using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Default_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputDictionarie = new Dictionary<string, string>();
            
            string line = Console.ReadLine();

            while (line != "end")
            {
                string[] tokens = line.Split(new[] {' ', '-', '>'} , StringSplitOptions.RemoveEmptyEntries).ToArray();
                string currentKey = tokens[0];
                string currentValue = tokens[1];

                inputDictionarie[currentKey] = currentValue;

                line = Console.ReadLine();
            }
            string defaultValue = Console.ReadLine();

            var notReplaced = inputDictionarie
                .Where(p => p.Value != "null")
                .OrderByDescending(p => p.Value.Length)               
                .ToDictionary(p => p.Key, p => p.Value);

            var replacedNull = inputDictionarie
                .Where(p => p.Value == "null")                              
                .ToDictionary(p => p.Key, p => defaultValue);
                    
            foreach (var ktp in notReplaced)
            {
                Console.WriteLine($"{ktp.Key} <-> {ktp.Value}");
            }
            foreach (var ktp in replacedNull)
            {
                Console.WriteLine($"{ktp.Key} <-> {ktp.Value}");
            }

        }
    }
}
