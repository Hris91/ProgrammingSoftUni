using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05.Capitalize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                List<string> result = input.Split(new[] { ',', ' ', '.', '!', '?','-',':',';' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                result = result.Select(w => w.ToLower()).ToList();

                for (int i = 0; i < result.Count; i++)
                {
                    char[] ToChar = result[i].ToCharArray();
                    string lower = ToChar[0].ToString();
                    string capitalLetter = ToChar[0].ToString().ToUpper();

                    result[i] = result[i].Remove(0, 1);
                    result[i] = capitalLetter + result[i];
                }
               
                Console.WriteLine(string.Join(", ",result));
                input = Console.ReadLine();
            }         
        }
    }
}
