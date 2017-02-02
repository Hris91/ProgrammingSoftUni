using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstOperand = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            int secondOperand = int.Parse(Console.ReadLine());

            switch (operation)
            {
                case '+':
                    Console.WriteLine($"{firstOperand} {operation} {secondOperand} = {firstOperand + secondOperand}");
                    break;
                case '-':
                    Console.WriteLine($"{firstOperand} {operation} {secondOperand} = {firstOperand - secondOperand}");
                    break;
                case '*':
                    Console.WriteLine($"{firstOperand} {operation} {secondOperand} = {firstOperand * secondOperand}");
                    break;
                case '/':
                    Console.WriteLine($"{firstOperand} {operation} {secondOperand} = {firstOperand / secondOperand}");
                    break;

            }
        }
    }
}
