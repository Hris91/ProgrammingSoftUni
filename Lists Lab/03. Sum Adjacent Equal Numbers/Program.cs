using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<int> numbers = input.Split(' ').Select(int.Parse).ToList();
            int newNumber = 0;

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i+1])
                {
                    newNumber = numbers[i] + numbers[i + 1];
                    numbers.RemoveAt(i);
                    numbers.RemoveAt(i);
                    numbers.Insert(i , newNumber);
                    if (i < numbers.Count/2)
                    {
                        i--;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
        }
    }
}
