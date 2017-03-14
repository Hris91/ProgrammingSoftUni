using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sort_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputArray = Console.ReadLine().Split(' ').ToArray();

            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                int j = i + 1;
               
                while (j > 0)
                {
                    int firstString = inputArray[j - 1].CompareTo(inputArray[j]);
                    int secondString = inputArray[j].CompareTo(inputArray[j - 1]);

                    if (firstString > secondString)
                    {
                        string temp = inputArray[j];
                        inputArray[j] = inputArray[j - 1];
                        inputArray[j - 1] = temp;

                    }
                    j--;
                }
            }
            Console.WriteLine(string.Join(" ", inputArray));
        }
    }
}
