using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int switchNumber=0;

            switchNumber = secondNumber;
            secondNumber = firstNumber;
            firstNumber = switchNumber;
            Console.WriteLine(firstNumber);
            Console.WriteLine(secondNumber);

        }
    }
}
