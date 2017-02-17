using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Count_of_Given_Element_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string addValues = Console.ReadLine();
            int[] numbers = addValues.Split(' ').Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == n)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
