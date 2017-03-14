using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Group_Continents__Countries_and_Cities
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ').ToArray();
                string continent = tokens[0];
                string country = tokens[1];
                string city = tokens[2];

                AddToData(continent, country, city, data);
            }

            foreach (var continentAndCountries in data)
            {
                var continentName = continentAndCountries.Key;
                var citiesByCountries = continentAndCountries.Value;
                Console.WriteLine($"{continentName}:");

                foreach (var ktp in citiesByCountries)
                {
                    Console.WriteLine($"  {ktp.Key} -> {string.Join(", ",ktp.Value)}");
                }
            }
        }

        private static void AddToData
            (string continent, string country, string city, SortedDictionary<string, SortedDictionary<string, SortedSet<string>>> data)
        {

            if (!data.ContainsKey(continent))
            {
                data[continent] = new SortedDictionary<string, SortedSet<string>>();
            }
            if (!data[continent].ContainsKey(country))
            {
                data[continent][country] = new SortedSet<string>();
            }

            data[continent][country].Add(city);
        }
    }
}
