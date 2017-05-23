using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fileLines = File.ReadAllLines("Input.txt");

            List<string> oddLines = new List<string>();

            for (int i = 1; i < fileLines.Length; i+=2)
            {
                oddLines.Add(fileLines[i]);
            }

            File.WriteAllLines("output.txt",oddLines);

        }
    }
}
