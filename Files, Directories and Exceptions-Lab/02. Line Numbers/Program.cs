using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace _02.Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("input.txt");
            int counter = 1;

            for (int i = 0; i < input.Length; i++)
            {
                input[i] = counter.ToString() + ". " + input[i];
                counter++;
            }

            File.WriteAllLines("output.txt",input);
        }
    }
}
