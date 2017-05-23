using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Rectangle_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle firstRectangle = ReadRectangle();
            Rectangle secondRectangle = ReadRectangle();

            bool result = firstRectangle.IsInside(secondRectangle);

            string printResult = result ? "Inside" : "Not inside";

            Console.WriteLine(printResult);

        }

        public static Rectangle ReadRectangle()
        {
            int[] recatangleParts = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            return new Rectangle()
            {
                Left = recatangleParts[0],
                Top = recatangleParts[1],
                Width = recatangleParts[2],
                Height = recatangleParts[3]
            };
        }
    }
}
