using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Odd_Numbers_at_Odd_Positions
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();

            int[] arreyOfNumbers = new int[numbers.Length];

            for (int i = 0; i < arreyOfNumbers.Length; i++)
            {
                arreyOfNumbers[i] = int.Parse(numbers[i]);
            }

            for (int i = 0; i < arreyOfNumbers.Length ; i++)
            {
                if (i % 2 != 0 && arreyOfNumbers[i] % 2 != 0 )
                {
                    Console.WriteLine($"Index {i} -> {arreyOfNumbers[i]}");
                }
            }
        }
    }
}
