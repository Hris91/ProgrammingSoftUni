using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _04.MergeFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fileOne = File.ReadAllLines("FileOne.txt");
            string[] fileTwo = File.ReadAllLines("FileTwo.txt");

            int[] result = fileOne.Concat(fileTwo).Select(int.Parse).ToArray();
            result = result.OrderBy(p => p).ToArray();
            
            Console.WriteLine(string.Join(Environment.NewLine, result));

            foreach (var line in result)
            {
                File.AppendAllText("result.txt", line + Environment.NewLine);
            }
            File.WriteAllLines("resultFinal.txt",result.Select(p => p.ToString()));

        }
    }
}
