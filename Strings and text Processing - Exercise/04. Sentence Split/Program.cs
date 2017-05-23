using System;
using System.Linq;


namespace _04.Sentence_Split
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string delimetersAsString = Console.ReadLine();
                   
            text.Replace(",", string.Empty);


            string[] result = text.Split(new string[] {delimetersAsString},StringSplitOptions.None).ToArray();

            Console.WriteLine($"[{string.Join(", ", result)}]");
        }
    }
}
