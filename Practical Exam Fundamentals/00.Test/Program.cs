using System;


namespace _00.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            long wormLengthInMeters = long.Parse(Console.ReadLine());
            decimal wormWidthInCantimeters = decimal.Parse(Console.ReadLine());

            long wormLengthInCantimeters = wormLengthInMeters * 100;
            decimal reminderOfDivision = 0m;
            decimal result = 0m;

            try
            {
                reminderOfDivision = wormLengthInCantimeters % wormWidthInCantimeters;
            }
            catch (Exception e)
            {
                reminderOfDivision = 0m;
                
            }

            if (reminderOfDivision == 0)
            {
                result = wormLengthInCantimeters * wormWidthInCantimeters;
                Console.WriteLine($"{result:f2}");
            }
            else
            {
                result = (wormLengthInCantimeters / wormWidthInCantimeters) * 100;
                Console.WriteLine($"{result:f2}%");
            }

           
        }
    }
}
