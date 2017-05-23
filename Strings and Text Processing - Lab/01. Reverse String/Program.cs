using System;


namespace _01.Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = Console.ReadLine();
            char[] newTest = test.ToCharArray();
            Array.Reverse(newTest);
            Console.WriteLine(string.Join("", newTest));
        }
    }
}
