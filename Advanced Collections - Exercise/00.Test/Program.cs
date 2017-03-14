using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _00.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var shellsByCities = new Dictionary<string, HashSet<int>>();

            string line = Console.ReadLine();

            while (line != "Aggregate")
            {
                string[] tokens = line.Split(' ').ToArray();
                string city = tokens[0];
                int shells = int.Parse(tokens[1]);

                AddShells(city, shells, shellsByCities);

                line = Console.ReadLine();
            }
            foreach (var ktp in shellsByCities)
            {
                Console.WriteLine($"{ktp.Key} -> {string.Join(", ",ktp.Value)} ({ktp.Value.Sum() - (ktp.Value.Sum() / ktp.Value.Count)})");
            }
        }

        private static void AddShells(string city, int shells, Dictionary<string, HashSet<int>> shellsByCities)
        {
            if (!shellsByCities.ContainsKey(city))
            {
                shellsByCities[city] = new HashSet<int>();
            }
            shellsByCities[city].Add(shells);
        }
    }
}
