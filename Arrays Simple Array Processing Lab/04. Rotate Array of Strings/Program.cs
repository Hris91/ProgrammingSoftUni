using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Rotate_Array_of_Strings
{
    class Program
    {
        

        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split().ToArray();
            string[] rotatedArrey = new string[array.Length];

            for (int i = 0; i < array.Length - 1; i++)
            {
                rotatedArrey[i + 1] = array[i];

            }
            string lastElement = array[rotatedArrey.Length - 1];
            rotatedArrey[0] = lastElement;
            Console.WriteLine(string.Join(" ",rotatedArrey));

        }
    }
}
