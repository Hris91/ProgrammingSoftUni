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
            int n =int.Parse(Console.ReadLine());

            var namesAndGrades = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                string name = input[0];
                double grade = double.Parse(input[1]);

                if (!namesAndGrades.ContainsKey(name))
                {
                    namesAndGrades[name] = new List<double>();
                }
                namesAndGrades[name].Add(grade);
            }

            foreach (var ktp in namesAndGrades)
            {
                Console.WriteLine($"{ktp.Key} -> {string.Join(" ", ktp.Value.Select(p => string.Format($"{p:f2}")))} (avg: {ktp.Value.Average():f2})");
            }
        }
    }
}
