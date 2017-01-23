using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Transport
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = 4 + 8 + 12;

            int courses = (int)Math.Ceiling((double)people / capacity);

            Console.WriteLine(courses);



        }
    }
}
