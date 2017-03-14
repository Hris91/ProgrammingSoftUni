using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _00.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentNumber = 83.105;
            string[] toString = currentNumber.ToString().Split('.');
            int toInt = int.Parse(toString[0]);
            char toChar = (char) toInt;
            Console.WriteLine(toChar);


        }
    }
}
