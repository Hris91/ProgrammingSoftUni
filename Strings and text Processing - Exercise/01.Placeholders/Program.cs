using System;
using System.Linq;


namespace _01.Placeholders
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            while (line != "end")
            {
                string[] text = line.Trim().Split(new []{ '-', '>' },StringSplitOptions.RemoveEmptyEntries).ToArray();
                string[] words = text[1].Trim().Split(new []{' ',','},StringSplitOptions.RemoveEmptyEntries).ToArray();
                

                string repalcedString = text[0];
                for (int i = 0; i < words.Length; i++)
                {                                    
                    repalcedString = repalcedString.Replace($"{{{i}}}", words[i]);                   
                }
               
                Console.WriteLine(repalcedString);

                line = Console.ReadLine();
            }

        }
    }
}
