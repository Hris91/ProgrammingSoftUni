using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<decimal> listOfInts = input.Split(' ').Select(decimal.Parse).ToList();

            listOfInts.Sort();
            Console.WriteLine(string.Join(" <= " , listOfInts));
            
        }
    }
}
