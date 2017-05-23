using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();                
            string[] inputString = Console.ReadLine().Split(' ').ToArray();
            
            for (int i = 0; i < inputString.Length; i++)
            {
                string currentWord = inputString[i];
                var randomPosition = rnd.Next(0, inputString.Length);

                string temporaryWord = inputString[randomPosition];
                inputString[randomPosition] = currentWord;
                inputString[i] = temporaryWord;

            }
            foreach (var word in inputString)
            {
                Console.WriteLine(word);
            }
        }
    }
}
