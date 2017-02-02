using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Distance_of_the_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal nearestStar = 4.22m * 9450000000000m;
            decimal centerGalaxy = 26000m * 9450000000000;
            decimal diameterMilkyWay = 100000m * 9450000000000;
            decimal edgeOfTheUniverse = 46500000000m * 9450000000000;

            string convert1 = string.Format("{0:e2}", nearestStar);
            string convert2 = string.Format("{0:e2}", centerGalaxy);
            string convert3 = string.Format("{0:e2}",diameterMilkyWay);
            string convert4 = string.Format("{0:e2}", edgeOfTheUniverse);
            
            Console.WriteLine(convert1);
            Console.WriteLine(convert2);
            Console.WriteLine(convert3);
            Console.WriteLine(convert4);
        }
    }
}
