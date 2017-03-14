using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _02.Average_Character_Delimiter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringInput = Console.ReadLine().Split(' ').ToArray();

            double sum = 0;
            int currentSum = 0;
            int count = 0;
           
            

            for (int i = 0; i < stringInput.Length; i++)
            {
                string currentString = stringInput[i];
                currentSum = FindSum(currentString);
                sum += currentSum;

                foreach (var character in currentString)
                {
                    count++;
                }
            }

            double avarage = Math.Floor(sum / count);
            char convertToChar = (char) avarage;

            string delimeter = convertToChar.ToString().ToUpper();
            Console.WriteLine(string.Join($"{delimeter}", stringInput));

        }

        static int FindSum(string currentString)
        {
            char[] charArray = currentString.ToCharArray();
            int toASCII = 0;
            int currentSum = 0;
            for (int i = 0; i < charArray.Length; i++)
            {
                toASCII = (int) charArray[i];
                currentSum += toASCII;
            }
            return currentSum;
        }
    }
}
