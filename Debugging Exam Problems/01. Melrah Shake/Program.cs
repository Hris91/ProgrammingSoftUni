using System;


namespace _01.Melrah_Shake
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            string inputPattern = Console.ReadLine();

            while (true)
            {
                int firstIndex = inputString.IndexOf(inputPattern);
                int lastIndex = inputString.LastIndexOf(inputPattern);

                if (firstIndex == -1 || lastIndex == -1 || inputPattern.Length == 0)
                {
                    Console.WriteLine("No shake.");
                    break;
                }

                if (firstIndex != -1 && lastIndex != -1 && firstIndex != lastIndex)
                {
                    firstIndex = inputString.IndexOf(inputPattern);
                    inputString = inputString.Remove(firstIndex, inputPattern.Length);
                    lastIndex = inputString.LastIndexOf(inputPattern);
                    inputString = inputString.Remove(lastIndex, inputPattern.Length);

                    inputPattern = inputPattern.Remove(inputPattern.Length / 2, 1);

                    Console.WriteLine("Shaked it.");
                }
            }
            Console.WriteLine(inputString);
        }
    }
}
