using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace _02.Worm_Ipsum
{
    class Program
    {
        static void Main(string[] args)
        {
            string lines = Console.ReadLine();
            List<string> resultSentances = new List<string>();

            while (lines != "Worm Ipsum")
            {
                int firstIndex = lines.IndexOf(".");
                int lastIndex = lines.LastIndexOf(".");
                bool isThereAQuestionMark = lines.Contains("?");
                bool isThereOtherSymbol = lines.Contains("!");

                string[] words = lines.Split(new[] { ' ', '.', ',', '-', ':', ';', '-', '\"', '\'', '[', ']', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
                char[] firstWord = words[0].ToCharArray();
                bool isItCapital = char.IsUpper(firstWord[0]);

                if (firstIndex == lastIndex && firstIndex != -1 && isItCapital && !isThereAQuestionMark && !isThereOtherSymbol && lastIndex - firstIndex != 1)
                {
                    foreach (var word in words)
                    {

                        string wordToLower = word.ToLower();
                        int mostCount = 0;
                        char charToChange = '?';

                        foreach (var letter in wordToLower.ToCharArray())
                        {
                            bool isItAChar = char.IsLetterOrDigit(letter);
                            if (isItAChar)
                            {
                                
                           
                            int counter = 0;
                            int index = wordToLower.IndexOf(letter);

                            while (index != -1)
                            {
                                counter++;
                                index = wordToLower.IndexOf(letter, index + 1);
                            }

                            if (counter >= 2 && counter > mostCount)
                            {
                                charToChange = letter;
                                mostCount = counter;
                            }
                        }
                    }
                        if (charToChange != '?')
                        {
                            int wordLenght = word.Length;
                            lines = lines.Replace(word, new string(charToChange, wordLenght));
                        }

                    }
                    resultSentances.Add(lines);
                }

                lines = Console.ReadLine();
            }

            foreach (var result in resultSentances)
            {
                Console.WriteLine(result);
            }

        }
    }
}
