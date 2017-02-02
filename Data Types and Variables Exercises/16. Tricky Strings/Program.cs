using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Tricky_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string delimeter = Console.ReadLine();
           
            int numberOfWords = int.Parse(Console.ReadLine());
            StringBuilder builder = new StringBuilder();
            for (int i = 1; i <= numberOfWords; i++)
            {
                string text = Console.ReadLine();
                builder.Append(text);
                if (i < numberOfWords)
                {
                    builder.Append(delimeter);
                }
                

            }
            Console.WriteLine(builder);
        }
    }
}
