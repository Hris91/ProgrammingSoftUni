using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Smallest_Element_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbersInArr = Console.ReadLine();
            int[] arrey = numbersInArr.Split(' ').Select(int.Parse).ToArray();

            int numberToCompare = int.MaxValue;

            for (int i = 0; i < arrey.Length; i++)
            {
                if (arrey[i] < numberToCompare)
                {
                    numberToCompare = arrey[i];
                }
            }
            Console.WriteLine(numberToCompare);
        }
    }
}
