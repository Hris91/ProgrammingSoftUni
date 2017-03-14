using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOne = new List<int>(){ 1, 2, 3, 4 };
            List<string> listTwo = new List<string>(){ "one", "two", "three", "four" };

            int i = listOne.IndexOf(3);
            Console.WriteLine(i);

        }
    }
}
