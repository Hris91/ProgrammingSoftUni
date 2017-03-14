using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Smallest_Element_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int minNumber = int.MaxValue;
            

            for (int i = 0; i < numbersArray.Length; i++)
            {
                if (numbersArray[i] < minNumber)
                {
                    minNumber = numbersArray[i];
                }
            }
            Console.WriteLine(minNumber);
        }
    }
}
