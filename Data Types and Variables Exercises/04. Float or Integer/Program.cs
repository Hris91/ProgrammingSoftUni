using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Float_or_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            bool isInt = number % 1 == 0;
            

            if (isInt==true)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine(Math.Round(number));
            }
        }
    }
}
