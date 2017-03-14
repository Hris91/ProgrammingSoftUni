using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Distinct_List
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<int> inputList = input.Split(' ').Select(int.Parse).ToList();

            int currentNumber = 0;
            int numberToCompare = 0;

            for (int i = 0; i < inputList.Count ; i++)
            {
                currentNumber = inputList[i];
               
                for (int j = i + 1; j < inputList.Count ; j++)
                {
                    numberToCompare = inputList[j];

                    if (currentNumber == numberToCompare)
                    {
                        inputList.RemoveAt(j);
                        j--;
                        
                    }
                }
            }
            Console.WriteLine(string.Join(" " , inputList));
        }
    }
}
