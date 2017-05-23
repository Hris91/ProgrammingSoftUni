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
            string[] names = new string[]
            {
                "Gosho","Atanas","Boris","Cecka"
            };

            names = names.OrderBy(p => p).ToArray();

            Console.WriteLine(string.Join(", ",names));
        }
    }
}
