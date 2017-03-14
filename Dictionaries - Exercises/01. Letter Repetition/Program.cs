using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _01.Letter_Repetition
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var letterDictionarie = new Dictionary<char,int>();

            foreach (var letter in input)
            {
                if (!letterDictionarie.ContainsKey(letter))
                {
                    letterDictionarie[letter] = 1;
                }
                else
                {
                    letterDictionarie[letter]++;
                }
                

            }
            foreach (KeyValuePair<char,int> letterIntPair in letterDictionarie)
            {
                Console.WriteLine($"{letterIntPair.Key} -> {letterIntPair.Value}");
            }
        }
    }
}
