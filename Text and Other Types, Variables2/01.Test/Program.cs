


namespace _01.Test
{
    using System;

    class SumOfDigits
    {
       public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                int currentNumber = i;
                int sum = 0;

                foreach (var symbol in currentNumber.ToString())
                {
                    var digit = symbol - '0';
                    sum += digit;
                }

                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }
    }
}
