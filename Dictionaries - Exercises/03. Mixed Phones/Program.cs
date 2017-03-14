using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Mixed_Phones
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var phoneBook = new SortedDictionary<string,decimal>();

            while (input != "Over")
            {
                string[] inputArray = input.Split(' ').ToArray();
                string firstElement = inputArray[0];
                string secondElement = inputArray[2];

                bool isFirstNumber = firstElement.All(Char.IsDigit);
                bool isSecondNumber = secondElement.All(Char.IsDigit);

                if (!isFirstNumber && isSecondNumber)
                {
                    if (!phoneBook.ContainsKey(firstElement))
                    {
                        phoneBook[firstElement] = decimal.Parse(secondElement);
                    }
                }
                else if (isFirstNumber && !isSecondNumber)
                {
                    phoneBook[secondElement] = decimal.Parse(firstElement);
                }
                input = Console.ReadLine();
            }
            foreach (KeyValuePair<string,decimal> kvp in phoneBook)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }

        }
    }
}
