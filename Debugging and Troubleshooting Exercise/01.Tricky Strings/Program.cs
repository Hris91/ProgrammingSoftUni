using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Tricky_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string delimiter = Console.ReadLine();
            int numberOfStrings = int.Parse(Console.ReadLine());
            

            string result = string.Empty;
            string currentString = string.Empty;


            for (int i = 1; i <= numberOfStrings; i++)
            {
                currentString = Console.ReadLine();
                if (i < numberOfStrings )
                {
                    result += currentString + delimiter;
                }
                else
                {
                    result += currentString;
                }
                
            }
            
            Console.WriteLine(result);
        }
    }
}
