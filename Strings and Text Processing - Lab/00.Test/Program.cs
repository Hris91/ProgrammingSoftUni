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
            string test = Console.ReadLine();
            char[] newTest = test.ToCharArray();
            Array.Reverse(newTest);           
            Console.WriteLine(string.Join("",test));
            
        }
    }
}
