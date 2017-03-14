using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Flip_List_Sides
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();



            string firstNumber = input[0];
            string lastNumber = input[input.Count - 1];

            input.Reverse();

            input[0] = firstNumber;
            input[input.Count - 1] = lastNumber;

            Console.WriteLine(string.Join(" ",input));

            

        }
    }
}
