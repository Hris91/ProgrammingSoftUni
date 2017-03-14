using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int k = input.Length / 4;

            var firstLeft = input.Take(k).Reverse().ToArray();
            
            var firstRight = input
                .Reverse()
                .Take(k)
                .ToArray();
            
            var firstRow = firstLeft.Concat(firstRight).ToList();

            var secondRow = input.Skip(k).Take(2 * k).ToList();

            var sum = new List<int>();
            for (int i = 0; i < firstRow.Count; i++)
            {
                int currentSum = firstRow[i] + secondRow[i];
                sum.Add(currentSum);
            }
           
            
            Console.WriteLine(string.Join(" ",sum));
         
        }
    }
}
