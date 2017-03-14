using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shoot_List_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            string input = Console.ReadLine();

            while (input != "stop")
            {
                if (input == "bang")
                {
                    
                }
                else
                {
                    int currentNumber = int.Parse(input);
                    numbers.Insert(0, currentNumber);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
