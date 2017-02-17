using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Phone
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split();
            string[] names = Console.ReadLine().Split();
            int symbolCounter = 0;

            string input = string.Empty;

            while (input != "done")
            {
                input = Console.ReadLine();

                for (int i = 0; i < names.Length; i++)
                {
                    if (input == $"call {phoneNumbers[i]}") //Calls a phone number.
                    {
                        foreach (var symbol in phoneNumbers[i])
                        {

                        }

                    }
                }


            }

        }
    }
}
