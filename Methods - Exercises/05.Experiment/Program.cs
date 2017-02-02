using System;


namespace _05.Experiment
{
    class Program
    {
        static string IntegerToBase(int number , int toBase)
        {
            string result = string.Empty;
            while (number > 0)
            {
                
                var reminder = number % toBase;
                result = reminder + result;
                number /= toBase;

            }
            return result;


            
        }
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int toBase = int.Parse(Console.ReadLine());

            var converted = IntegerToBase(number, toBase);
            Console.WriteLine(converted);
        }
    }
}
