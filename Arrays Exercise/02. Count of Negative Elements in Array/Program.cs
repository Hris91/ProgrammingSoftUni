using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Count_of_Negative_Elements_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrayOfNumbers = new int[n];
            int counter = 0;
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                if (numbers < 0)
                {
                    counter++;
                }

            }
            Console.WriteLine(counter);
        }
    }
}
