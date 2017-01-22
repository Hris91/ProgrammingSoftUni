using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Circle_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double peremeter = 2 * Math.PI * r;
            Console.WriteLine($"{peremeter:f12}");
        }
    }
}
