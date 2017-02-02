using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Min_Method
{
    class Program
    {
        static int GetMin(int first , int second , int third)
        {
            if (first <= second && first < third )
            {
                return first;
            }
            else if(second <= first && second < third)
            {
                return second;
            }
            else if (third <= first && third < second)
            {
                return third;
            }
            else
            {
                return 0;
            }
            
        }
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int min = GetMin(first, second, third);
            Console.WriteLine(min);
        }
    }
}
