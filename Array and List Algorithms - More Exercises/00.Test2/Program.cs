using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            int command = 5;
            int currentIndex = 1;

            string[] originalArray = new string[] {"zero", "one", "two", "three", "four", "five", "six"};
            int newIndex = 0;
            int IndexToRemove = 0;

            for (int j = 0; j < currentIndex; j++)
            {
                IndexToRemove++;
            }
            newIndex = (command - IndexToRemove ) % originalArray.Length;

            Console.WriteLine(originalArray[newIndex]);

           
           

        }
    }
}
