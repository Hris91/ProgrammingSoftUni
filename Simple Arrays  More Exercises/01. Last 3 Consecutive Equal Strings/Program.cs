using System;


namespace _01.Last_3_Consecutive_Equal_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] wordsInput = Console.ReadLine().Split();
           
          
            string lastWord = string.Empty;

            for (int i = 1; i < wordsInput.Length-1; i++)
            {
                if (wordsInput[i] == wordsInput[i-1] && wordsInput[i] == wordsInput[i+1] )
                {
                    lastWord = wordsInput[i];
                }
            }
            Console.WriteLine($"{lastWord} {lastWord} {lastWord}");





        }
    }
}
