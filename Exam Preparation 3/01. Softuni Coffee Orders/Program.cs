using System;
using System.Globalization;

namespace _01.Softuni_Coffee_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            decimal pricePerCapsule = 0;
            string dateAsString = string.Empty;
            long capsulesCount = 0;
            decimal total = 0;


            for (int i = 0; i < n; i++)
            {
                pricePerCapsule = decimal.Parse(Console.ReadLine());
                dateAsString = Console.ReadLine();
                capsulesCount = int.Parse(Console.ReadLine());

                DateTime date = DateTime.ParseExact(dateAsString, "d/M/yyyy", CultureInfo.InvariantCulture);
                int year = date.Year;
                int month = date.Month;
                int daysInMonth = System.DateTime.DaysInMonth(year, month);
                decimal priceAfterDisscount = ((daysInMonth * capsulesCount) * pricePerCapsule);
                total += priceAfterDisscount;

                Console.WriteLine($"The price for the coffee is: ${priceAfterDisscount:f2}");

            }
            Console.WriteLine($"Total: ${total:f2}");
           
        }
    }
}
