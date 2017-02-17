using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string enterValues = Console.ReadLine();
            List<int> numbers = enterValues.Split(' ').Select(int.Parse).ToList();
            List<int> withotNegatives = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > 0)
                {
                    withotNegatives.Add(numbers[i]);
                }

            }
            withotNegatives.Reverse();

            if (withotNegatives.Count == 0)
            {
                Console.WriteLine("empty");
            }
            
            else 
            {
                Console.WriteLine(string.Join(" " , withotNegatives));  
            }
        }
    }
}
