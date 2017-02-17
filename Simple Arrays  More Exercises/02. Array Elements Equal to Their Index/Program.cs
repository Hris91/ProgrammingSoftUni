using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Array_Elements_Equal_to_Their_Index
{
    class Program
    {
        static void Main(string[] args)
        {
            string enterValues = Console.ReadLine();
            int[] arrayOfNumbers = enterValues.Split(' ').Select(int.Parse).ToArray();
            int[] equalToIndex = new int[arrayOfNumbers.Length];
            int counter = 0;

            for (int i = 0; i < arrayOfNumbers.Length; i++) 
            {
                if (arrayOfNumbers[i] == i)
                {
                    equalToIndex[counter] = arrayOfNumbers[i];
                    counter++;
                }
            }

            for (int i = 0; i < counter; i++)
            {
                
                Console.Write($"{equalToIndex[i]} ");
            }
        }
    }
}
