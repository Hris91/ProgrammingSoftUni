using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfDoubles = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            var counts = new SortedDictionary<double,int>();

            foreach (var number in listOfDoubles)
            {
                if (!counts.ContainsKey(number))
                {
                    counts[number] = 0;
                }
                counts[number]++;
            }

            foreach (KeyValuePair<double,int> pair in counts)
            {               
                string isMoreThanOne = pair.Value == 1 ? "time" : "times";
                Console.WriteLine($"{pair.Key} -> {pair.Value} {isMoreThanOne}");
            }

        }
    }
}
