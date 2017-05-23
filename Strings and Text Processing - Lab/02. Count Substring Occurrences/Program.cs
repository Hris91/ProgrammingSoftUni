using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Count_Substring_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string pattern = Console.ReadLine().ToLower();

            int counter = 0;
            int indexOf = input.IndexOf(pattern);

            while (indexOf != -1)
            {
                counter++;
                indexOf = input.IndexOf(pattern, indexOf + 1);
            }
            Console.WriteLine(counter);
        }
    }
}
