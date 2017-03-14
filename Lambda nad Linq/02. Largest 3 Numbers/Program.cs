using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .OrderByDescending(n => n)
                .ToList();

            if (numbers.Count >= 3)
            {
                var ifThreeOrMore = numbers.Take(3).ToList();
                Console.WriteLine(string.Join(" ", ifThreeOrMore));
            }
            else
            {
                Console.WriteLine(string.Join(" ", numbers));
            }

            
        }
    }
}
