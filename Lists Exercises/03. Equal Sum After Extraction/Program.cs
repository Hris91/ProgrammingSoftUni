using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Equal_Sum_After_Extraction
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstInput = Console.ReadLine();
            string secondInput = Console.ReadLine();

            List<int> firstList = firstInput.Split(' ').Select(int.Parse).ToList();
            List<int> secondList = secondInput.Split(' ').Select(int.Parse).ToList();
            int i = 0;
            int sumFirstList = 0;
            int sumSecondList = 0;

            do
            {
                secondList.Remove(firstList[i]);
                i++;

            } while (i < firstList.Count);

            for (int j = 0; j < firstList.Count; j++)
            {
                sumFirstList += firstList[j];
            }

            for (int j = 0; j < secondList.Count; j++)
            {
                sumSecondList += secondList[j];
            }

            if (sumFirstList == sumSecondList)
            {
                Console.WriteLine($"Yes. Sum: {sumFirstList}");
            }
            else
            {
                Console.WriteLine($"No. Diff: {Math.Abs(sumSecondList - sumFirstList)}");
            }
            
        }
    }
}
