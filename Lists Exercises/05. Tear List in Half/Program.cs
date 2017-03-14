using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Tear_List_in_Half
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<int> numbers = input.Split(' ').Select(int.Parse).ToList();
            List<int> upperHalf = new List<int>();
            List<int> lowerHalf = new List<int>();
            List<int> result = new List<int>();

            int decreaisng = numbers.Count - 1;
            int firstNumber = 0;
            int secondNumber = 0;
            int count = 0;



            for (int i = 0; i < numbers.Count / 2; i++)
            {
                lowerHalf.Add(numbers[i]);
                upperHalf.Add(numbers[decreaisng]);
                decreaisng--;

               
            }
            upperHalf.Reverse();
            for (int i = 0; i < lowerHalf.Count  ; i++)
            {
                firstNumber = upperHalf[i] / 10;
                secondNumber = upperHalf[i] % 10;

                result.Add(firstNumber);
                result.Add(lowerHalf[count]);
                result.Add(secondNumber);
                count++;
                
               
            }


            Console.WriteLine(string.Join(" ", result));
            


        }
    }
}
