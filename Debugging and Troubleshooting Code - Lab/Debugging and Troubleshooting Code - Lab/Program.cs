using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugging_and_Troubleshooting_Code___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            n = Math.Abs(n);
            int result = GetmultipleOfEvensandOdds(n);
            Console.WriteLine(result);

        }

        static int GetmultipleOfEvensandOdds(int n)
        {
            int sumEvens = GetSumOfEvenDigits(n);
            int sumOdds = GestSumOfOddDigits(n);
            return sumEvens * sumOdds;
        }

         static int GestSumOfOddDigits(int n)
        {
            int sum = 0;

            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }

                n /= 10;
                
            }
            return sum;
        }

        private static int GetSumOfEvenDigits(int n)
        {
            int sum = 0;

            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }

                n /= 10;

            }
            return sum;
        }
    }
}
