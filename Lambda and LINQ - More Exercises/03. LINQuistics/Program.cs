using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _03.LINQuistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var collectionsAndMethods = new Dictionary<string, List<string>>();

            string line = Console.ReadLine();

            while (line != "exit")
            {
                string[] tokens = line.Split(new[] {'.', '(', ')'}, StringSplitOptions.RemoveEmptyEntries);
                int isItNumber = 0;
                string collectionName = tokens[0];

                if ( tokens.Length > 1)
                {                  
                    AddToDictionarie(collectionName, tokens, collectionsAndMethods);
                }
                else if (tokens.Length == 1 && !int.TryParse(tokens[0], out isItNumber) && collectionsAndMethods.ContainsKey(collectionName))
                {                
                    collectionsAndMethods[collectionName]
                        .OrderByDescending(method => method.ToCharArray().Length)
                        .ThenByDescending(method => method.ToCharArray().Distinct().Count())                      
                        .ToList()
                        .ForEach(method => Console.WriteLine($"* {method}"));                                     
                }
                else if (tokens.Length == 1 && int.TryParse(tokens[0], out isItNumber))
                {
                    string max = collectionsAndMethods.Aggregate((l, r) => l.Value.Count > r.Value.Count ? l : r).Key;

                    collectionsAndMethods[max]
                        .ToList()
                        .OrderBy(x => x.ToCharArray().Length)
                        .Take(collectionsAndMethods[max].Count < isItNumber ? collectionsAndMethods[max].Count : isItNumber)
                        .ToList()
                        .ForEach(x => Console.WriteLine($"* {x}"));   

                }
                line = Console.ReadLine();
            }
            string[] command = Console.ReadLine().Split(' ').ToArray();

            foreach (var collection in collectionsAndMethods
                   .OrderByDescending(x => x.Value.Count))
            {
                if (collection.Value.Contains(command[0]) && command[1] == "all")
                {
                    Console.WriteLine(collection.Key);
                    var methods = collection.Value;
                    

                    foreach (var method in methods.OrderByDescending(x => x.ToCharArray().Length))
                    {
                        Console.WriteLine($"* {method}");
                    }
                }
                else
                {
                    if (collection.Value.Contains(command[0]))
                    {
                        Console.WriteLine(collection.Key);
                    }
                  
                }
            }
                                        

        }

        private static void AddToDictionarie(string collectionName, string[] tokens,
            Dictionary<string, List<string>> collectionsAndMethods)
        {
            if (!collectionsAndMethods.ContainsKey(collectionName))
            {
                collectionsAndMethods[collectionName] = new List<string>();
            }
            for (int i = 1; i < tokens.Length; i++)
            {
                if (!collectionsAndMethods[collectionName].Contains(tokens[i]))
                {
                    collectionsAndMethods[collectionName].Add(tokens[i]);
                }
            }
        }
    }
}
