using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var alcoholTypes = Console.ReadLine().Split(' ').ToArray();
            var drunkDictionarie = new Dictionary <string, List<string>>();

            string drinks = string.Empty;
            foreach (var alcohol in alcoholTypes)
            {
                Console.Write($"Add alcohol to alcohol type {alcohol} -->");
                drunkDictionarie[alcohol] = Console.ReadLine().Split(' ').ToList();
            }

            foreach (KeyValuePair<string, List<string>> kvp in drunkDictionarie)
            {
                Console.WriteLine($"{kvp.Key} ---> {string.Join(", ",kvp.Value)}");
            }

        }
    }
}
