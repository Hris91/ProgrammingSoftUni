using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Largest_Element_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arreyOfInts = new int[n];
            int biggestNumber = int.MinValue;

            for (int i = 0; i < arreyOfInts.Length; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                if (biggestNumber < numbers)
                {
                    biggestNumber = numbers;
                }
                
               
            }
            Console.WriteLine(biggestNumber);
        }
    }
}
