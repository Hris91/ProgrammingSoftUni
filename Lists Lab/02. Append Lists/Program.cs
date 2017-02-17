using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            List<string> values = input.Split('|').ToList();
            List<string> result = new List<string>();
            string currentToken = string.Empty;
            string stringWithoutSpaces = string.Empty;
            string reversedToken = string.Empty;


            for (int i = 0; i < values.Count; i++)
            {
                currentToken = values[i];
                stringWithoutSpaces = TakeAwaySpaces(currentToken);                
                result.Add(stringWithoutSpaces);
                

            }
            result.Reverse();
            Console.WriteLine(string.Join(" " , result));




        }
        static string TakeAwaySpaces(string stringWithSpaces) //Takes away aditional spaces.
        {
            string stringWithoutSpaces = string.Join(" ", stringWithSpaces.Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries));
            return stringWithoutSpaces;
        }
        
    }
}
