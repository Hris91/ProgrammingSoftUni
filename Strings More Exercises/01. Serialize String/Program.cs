using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Serialize_String
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> result = new List<char>();
            string text = Console.ReadLine();
            char[] toSymbols = text.ToCharArray();

            foreach (var symbol in toSymbols)
            {
                if (!result.Contains(symbol))
                {
                    result.Add(symbol);
                }
            }

            foreach (var symbol in result)
            {
                List<int> printIndex = new List<int>();
                int index = text.IndexOf(symbol);
                if (index != -1)
                {
                    printIndex.Add(index);
                }
              
                while (index != -1)
                {
                    index = text.IndexOf(symbol, index + 1);
                   
                    if (index != -1)
                    {
                        printIndex.Add(index);
                    }
                }

                Console.WriteLine($"{symbol}:{string.Join("/",printIndex)}");
            }
        }
    }
}
