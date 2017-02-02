using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Draw_a_Filled_Square
{
    class Program
    {
        static void PrintDashes(int n)
        {
            string dashes= (new string('-', 2 * n));
            Console.WriteLine(dashes);
        }
        static void PrintBody(int n)
        {
            for (int i = 1; i <= n-2; i++)
            {
                Console.Write('-');
                for (int j = 1; j < n; j++)
                {
                    Console.Write(@"\/");
                }
                Console.WriteLine('-');
            }
                                     

        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintDashes(n);
            PrintBody(n);
            PrintDashes(n);
            
        }
    }
}
