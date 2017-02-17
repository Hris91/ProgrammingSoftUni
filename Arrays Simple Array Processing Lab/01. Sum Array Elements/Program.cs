using System;


namespace _01.Sum_Array_Elements
{
    class Program
    {
       public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];
            int sumOfNumbers = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                sumOfNumbers +=numbers [i];

            }
            Console.WriteLine(sumOfNumbers);
        }
    }
}
