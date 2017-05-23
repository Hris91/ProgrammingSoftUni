using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Wormhole
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] path = Console.ReadLine()
                .Split(new []{' '},StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int stepsTaken = 0;

            for (int i = 0; i < path.Length; i++)
            {
                int step = path[i];

                stepsTaken++;
                if (path[i] != 0)
                {
                    path[i] = 0;
                    i = step;                    
                   
                }                
            }
            Console.WriteLine(stepsTaken);
        }
    }
}
