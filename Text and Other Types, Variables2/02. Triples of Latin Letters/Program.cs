using System;


namespace _02.Triples_of_Latin_Letters
{
    class Program
    {
       public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                for (int b = 0; b < number; b++)
                {
                    for (int c = 0; c < number; c++)
                    {
                        char firstLetter = (char)(i + 'a');
                        char secondLetter = (char)(b + 'a');
                        char thirdLetter = (char)(c + 'a');
                        Console.WriteLine($"{firstLetter}{secondLetter}{thirdLetter}");
                    }
                }
            }
        }
    }
}
