using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Equal_Sequence_of_Elements_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string enterValues = Console.ReadLine();
            int[] arrayOfInts = enterValues.Split(' ').Select(int.Parse).ToArray();
            bool ifEqual = false;

            for (int i = 1; i < arrayOfInts.Length; i++)
            {
                if (arrayOfInts[i] == arrayOfInts[i-1])
                {
                    ifEqual = true;
                }
                else
                {
                    ifEqual = false;
                    Console.WriteLine("No");
                    break;
                }
            }
            if (ifEqual == true)
            {
                Console.WriteLine("Yes");
            }
        }
    }
}
