using System;
using System.Collections.Generic;
using System.IO;


namespace _01.Filter_Extensions
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] fileNames = Directory.GetFiles("input");
            List<string> result = new List<string>();

            foreach (var file in fileNames)
            {
                string[] currentFile = file.Split('.');

                if (currentFile[currentFile.Length - 1] == input)
                {
                    result.Add(file);
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, result));


            
        }
    }
}
