using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _02.Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            var geography = new Dictionary<string, Dictionary<string, List<string>>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(' ').ToArray();

                string continent = line[0];
                string country = line[1];
                string city = line[2];

                AddToLists(continent, country, city, geography);
            }

            foreach (var continent in geography.Keys)
            {
                Console.WriteLine($"{continent}:");
                var countriesInContinent = geography[continent];

                foreach (var country in countriesInContinent)
                {
                    Console.WriteLine($"  {country.Key} -> {string.Join(", ",country.Value)}");
                }
            }
        }

        private static void AddToLists(string continent, string country, string city, Dictionary<string, Dictionary<string, List<string>>> geography)
        {
            if (!geography.ContainsKey(continent))
            {
                geography[continent] = new Dictionary<string, List<string>>();
            }

            if (!geography[continent].ContainsKey(country))
            {
                geography[continent][country] = new List<string>();
            }

            geography[continent][country].Add(city);
        }
    }
}
