using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 2, 6, 1, 5, 7, 8, 9 };
            Array.Sort(numbers);
            int index = Array.IndexOf(numbers, 6);

            Console.WriteLine(string.Join(" ", numbers));
            Console.WriteLine(index);
        }
    }
}
