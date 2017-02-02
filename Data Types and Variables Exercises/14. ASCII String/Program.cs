using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.ASCII_String
{
    class Program
    {
        static void Main(string[] args)
        {
            int counterNumbers = int.Parse(Console.ReadLine());
            char numberToChar = '0';
            StringBuilder builder = new StringBuilder();
            

            for (int i = 0; i < counterNumbers; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                numberToChar = Convert.ToChar(numbers);
                builder.Append(numberToChar);
                

               
            }
            Console.WriteLine(builder);
           
        }
    }
}
