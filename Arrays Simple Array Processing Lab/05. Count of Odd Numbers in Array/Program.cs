using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Count_of_Odd_Numbers_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbersInArr = Console.ReadLine();
            int[] arrey = numbersInArr.Split(' ').Select(int.Parse).ToArray();

            int counter = 0;

            for (int i = 0; i < arrey.Length; i++)
            {
                if (arrey[i] % 2 == 1 || arrey[i] % 2 == -1)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
