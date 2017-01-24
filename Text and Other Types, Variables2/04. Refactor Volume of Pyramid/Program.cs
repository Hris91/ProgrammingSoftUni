using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {


            int n = int.Parse(Console.ReadLine());
            int obshto = 0;
            

            for (int i = 1; i <= n; i++)
            {
              int  digit = i;
                while (i > 0)
                {
                    obshto += i % 10;
                    i = i / 10;
                }
               bool number = (obshto == 5) || (obshto == 7) || (obshto == 11);
                Console.WriteLine($"{digit} -> {number}");
                obshto = 0;
                i = digit;




            }

        }
    }
}
