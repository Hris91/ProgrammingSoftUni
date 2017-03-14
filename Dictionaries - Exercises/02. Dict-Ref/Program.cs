using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _02.Dict_Ref
{
    class Program
    {
        static void Main(string[] args)
        {
            var referencedDictionarie = new Dictionary<string,int>();
            string addString = Console.ReadLine();

            while (addString != "end")
            {
                
                if (addString == "end")
                {
                    break;
                }
                string[] input = addString.Split(' ').ToArray();

                string name = input[0];
                int value = 0;
                bool isItaNumber = int.TryParse(input[2], out value);

                if (isItaNumber)
                {
                    referencedDictionarie[name] = value;
                }
                else
                {
                    string secondName = input[2];

                    if (referencedDictionarie.ContainsKey(input[2]))
                    {
                        referencedDictionarie[input[0]] = referencedDictionarie[input[2]];
                    }
                 
                }
                 addString = Console.ReadLine();

            }

            foreach (KeyValuePair<string,int> kvp in referencedDictionarie)
            {
                Console.WriteLine($"{kvp.Key} === {kvp.Value}");
            }       
        }
    }
}
