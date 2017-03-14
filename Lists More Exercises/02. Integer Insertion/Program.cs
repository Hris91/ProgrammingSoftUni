using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Integer_Insertion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<int> inputList = input.Split(' ').Select(int.Parse).ToList();
            
            int firstDigit = 0;
            int convertedToInt = 0;

            string stringInput = string.Empty;

            while(true)
            {
                stringInput = Console.ReadLine();
                if (stringInput == "end")
                {
                    break;
                }  
                          
                string currentNumber = stringInput;
                firstDigit = TakeFirstDigit(currentNumber);
                convertedToInt = int.Parse(currentNumber);

                inputList.Insert(firstDigit, convertedToInt);

            } 

            Console.WriteLine(string.Join(" ", inputList));
        }

        static int TakeFirstDigit(string stringInput)
        {
            char[] CharArray = stringInput.ToCharArray();
            string toString = CharArray[0].ToString();
            int n = int.Parse(toString);
            return n;
        }
    }
}
