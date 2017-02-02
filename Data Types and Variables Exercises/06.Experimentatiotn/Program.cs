using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Experimentatiotn
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int counterOverFlows = 0;
           

            if (number <= 255)
            {
                Console.WriteLine(number);
            }
            else
            {
                int newNumber = 0;
                for (int i = 0; i < number; i++)
                {
                    
                    if (newNumber == 255)
                    {
                        newNumber = 0;
                        counterOverFlows++;
                        continue;
                    }
                    newNumber++;




                }
                Console.WriteLine(newNumber);
                Console.WriteLine($"Overflowed {counterOverFlows} times");
            }


            



        }
    }
}
