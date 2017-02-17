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
            string what = Console.ReadLine();
            char[] chars = what.ToCharArray();
            int ASCII = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                ASCII = (int)chars[i];
                Console.WriteLine(ASCII);
            }
        }
    }
}
