using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _03.Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = File.ReadAllText("words.txt").ToLower().Split(' ');
            string[] text = File.ReadAllText("text.txt")
                .ToLower()
                .Split(new char[] {'\n', '\r', ' ', '.', ',', '!', '?', '-'}, StringSplitOptions.RemoveEmptyEntries);
                
            var result = new Dictionary<string,int>();

            foreach (var word in words)
            {
                result[word] = 0;
            }

            foreach (var word in text)
            {
                if (result.ContainsKey(word))
                {
                    result[word]++;
                }
            }
            
            foreach (var kvp in result)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
                File.AppendAllText("result2.txt", $"{kvp.Key} -> {kvp.Value}" + Environment.NewLine);
            }

        }
    }
}
