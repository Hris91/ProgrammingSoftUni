using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _05.Decode_Radio_Frequencies
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputArray = Console.ReadLine().Split(' ').ToArray();
            List<char> resultListLeft = new List<char>();
            List<char> resultListRight = new List<char>();
                   
            for (int i = 0; i < inputArray.Length; i++)
            {
                string currentNumber = inputArray[i];
                string[] toString = currentNumber.Split('.');

                int leftInt = int.Parse(toString[0]);
                int rightInt = int.Parse(toString[1]);

                if (leftInt != 0)
                {
                    char toCharLeft = (char)leftInt;
                    resultListLeft.Add(toCharLeft);
                }
                if (rightInt != 0)
                {
                    char toCharRight = (char) rightInt;
                    resultListRight.Add(toCharRight);
                }               
            }

            resultListRight.Reverse();

            for (int i = 0; i < resultListRight.Count; i++)
            {
                resultListLeft.Add(resultListRight[i]);
            }

            foreach (var character in resultListLeft)
            {
                Console.Write(character);
            }
            Console.WriteLine();
        }
    }
}
