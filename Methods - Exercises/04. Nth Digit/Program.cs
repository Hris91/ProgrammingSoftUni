using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Nth_Digit
{
    class Program
    {
        static int FindnthDigit(long number , int index)
        {
            int counter = 1;            
            while (number > 0)
            {
                
                if (counter == index)
                {
                    return (int)(number % 10);
                }
                number /= 10;
                counter++;

            }
            return (int)(number % 10);
        }
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());
            int digitAtIndex = FindnthDigit(number, index);
            Console.WriteLine(digitAtIndex);
        }
    }
}
