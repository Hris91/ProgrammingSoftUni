using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shoot_List_Elements2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            
            int lastElement = 0;
            double averageElement = 0.0;
            string input = string.Empty;

            while (input != "stop")
            {
                 input = Console.ReadLine();

                if (input == "bang")
                {
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine($"nobody left to shoot! last one was {lastElement}");
                        return;
                    }
                  
                    double listSum = numbers.Sum();
                    double count = numbers.Count();
                    averageElement = listSum / count;

                    lastElement = RemoveNumber(numbers, averageElement);
                    DecrementElements(numbers);
                }
                else if (input == "stop")
                {
                    break;
                }
                else
                {
                    int number = int.Parse(input);
                    numbers.Insert(0, number);
                   
                }                             
            }
            if (numbers.Count > 0)
            {
                Console.WriteLine($"survivors: {string.Join(" ",numbers)}");
            }
            else
            {
               Console.WriteLine($"you shot them all. last one was {lastElement}");
            }
                  
        }

        static int RemoveNumber(List<int> numbers, double averageElement)
        {

            int lastElement = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] <= averageElement)
                {
                    Console.WriteLine("shot {0}", numbers[i]);
                    lastElement = numbers[i];
                    numbers.RemoveAt(i);
                    break;
                }
            }
            return lastElement;
        }

        static void DecrementElements(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i]--;
            }
        }
       
    }
}
