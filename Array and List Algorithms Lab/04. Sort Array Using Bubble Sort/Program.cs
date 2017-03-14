using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sort_Array_Using_Bubble_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            bool swaped = false;

            do
            {
                swaped = false;
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    int firstNumber = numbers[i];
                    int secondNumber = numbers[i + 1];

                    if (firstNumber > secondNumber)
                    {
                        int temp = firstNumber;
                        numbers[i + 1] = firstNumber;
                        numbers[i] = secondNumber;
                        swaped = true;
                    }
                }
            } while (swaped);

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
