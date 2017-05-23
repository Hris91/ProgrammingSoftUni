using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _01.Lambada_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<string , Dictionary<string, string>>();
            
            var dancingSelectors = new Dictionary<string, List<string>>();
            string line = Console.ReadLine();
           

            while (line != "lambada")
            {
                string[] tokens = line.Split(new []{' ', '=', '>', '.'},StringSplitOptions.RemoveEmptyEntries).ToArray();
                string danceOrCollector = tokens[0];

                if (danceOrCollector != "dance")
                {
                  AddToDictionary(dictionary, tokens);
                }
                else
                {
                    dictionary = dictionary.ToDictionary(selector => selector.Key, selector => selector.Value.ToDictionary(
                        selectorObject => selectorObject.Key,
                        selectorObject => selectorObject.Key + "." + selectorObject.Value));
                }
                line = Console.ReadLine();
            }
          

            foreach (var selector in dictionary)
            {
                foreach (var selectorObject in selector.Value)
                {
                    Console.WriteLine($"{selector.Key} => {selectorObject.Key}.{selectorObject.Value}");
                }
            }

            
        }

        private static void AddToDictionary(Dictionary<string, Dictionary<string, string>> dictionary, string[] tokens)
        {
            string selector = tokens[0];
            string selectorObject = tokens[1];
            string property = tokens[2];

            if (!dictionary.ContainsKey(selector))
            {
                dictionary[selector]= new Dictionary<string, string>();
            }
            dictionary[selector][selectorObject] = property;

        }
    }
}
