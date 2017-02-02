using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.String_Repeater
{
    class Program
    {
        static string StringRepeater (string str, int count)
        {

            StringBuilder builder = new StringBuilder(str);
            for (int i = 1; i < count; i++)
            {
                builder.Append(str);
            }
            return builder.ToString();
        }
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            string repeater = StringRepeater(str,count);
            Console.WriteLine(repeater);
        }
    }
}
