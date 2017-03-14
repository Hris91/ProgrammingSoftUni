using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Camel_s_Back
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> n = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int m = int.Parse(Console.ReadLine());
            int rounds = (n.Count - m) /2;          
            if (m == n.Count)
            {
                Console.WriteLine($"already stable: {string.Join(" ", n)}");
            }
            else
            {
                for (int i = 0; i < rounds; i++)
                {
                    n.RemoveAt(n.Count - 1);
                    n.RemoveAt(0);


                }
                Console.WriteLine($"{rounds} rounds");
                Console.WriteLine($"remaining: {string.Join(" ", n)}");
            }
           
        }
    }
}
