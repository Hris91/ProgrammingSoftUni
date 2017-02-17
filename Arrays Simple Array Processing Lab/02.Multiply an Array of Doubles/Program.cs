using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Multiply_an_Array_of_Doubles
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringArrey = Console.ReadLine().Split();
            double[] arrey = new double[stringArrey.Length];
            double p = double.Parse(Console.ReadLine());
           

            for (int i = 0; i < arrey.Length; i++)
            {
                arrey[i] = double.Parse(stringArrey[i]);
            }
            double result = 0.0;

            for (int i = 0; i < arrey.Length; i++)
            {
                result = arrey[i] * p;                
                Console.Write(result + " ");
                result = 0;
            }
           

        }
    }
}
