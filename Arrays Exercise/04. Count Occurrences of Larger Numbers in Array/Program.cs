using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Count_Occurrences_of_Larger_Numbers_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string enterValues = Console.ReadLine();
            double[] numbersArray = enterValues.Split(' ').Select(double.Parse).ToArray();
            double p = double.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 0; i < numbersArray.Length; i++)
            {
                if (numbersArray[i] > p)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);

        }
    }
}
