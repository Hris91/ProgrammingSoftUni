using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.ExperimentOfDoom
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] symbols = Console.ReadLine().ToCharArray();
            string numberInput = Console.ReadLine();
            int[] numbers = numberInput.Split(' ').Select(int.Parse).ToArray();

            int currentCode = 0;
            string toString = string.Empty;
            string stringConversion = string.Empty;
            string finishedString = string.Empty;


            for (int i = 0; i < numbers.Length; i++)
            {

                if (numbers[i] % 2 != 1)
                {
                    currentCode = Math.Abs(numbers[i] + symbols[i]);
                }
                else if (numbers[i] % 2 == 1)
                {
                    currentCode = Math.Abs(numbers[i] - symbols[i]);
                }



                toString = Char.ConvertFromUtf32(currentCode);
                stringConversion = Convert.ToString(toString);
                finishedString += stringConversion;


                currentCode = 0;


            }
            Console.WriteLine(finishedString);

        }
    }
}
