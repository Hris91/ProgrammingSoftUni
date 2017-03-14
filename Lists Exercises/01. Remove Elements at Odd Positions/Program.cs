using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Remove_Elements_at_Odd_Positions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> strings = Console.ReadLine().Split(' ').ToList();
            List<string> newStrings = new List<string>();
            int counter = 1;

            for (int i = 0; i < strings.Count; i++)
            {
                if (counter % 2 == 0)
                {
                    newStrings.Add(strings[i]);
                    
                }
                counter++;
            }
            Console.WriteLine(string.Join("",newStrings));
        }
       
    }
}
