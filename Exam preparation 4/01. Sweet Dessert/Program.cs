using System;


namespace _01.Sweet_Dessert
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal CashOfIvancho = decimal.Parse(Console.ReadLine());
            long numberOfGuests = long.Parse(Console.ReadLine());
            decimal priceOfBananas = decimal.Parse(Console.ReadLine());
            decimal priceOfEggs = decimal.Parse(Console.ReadLine());
            decimal priceOFBerries = decimal.Parse(Console.ReadLine());

            long portionsSetsNeeded = 0l;

            for (int i = 0; i < numberOfGuests; i+=6)
            {
                portionsSetsNeeded ++;
            }

            long bananasNeeded = portionsSetsNeeded * 2;
            long eggsNeeded = portionsSetsNeeded * 4;
            decimal berriesNeeded = portionsSetsNeeded * 0.2M;

            decimal moneyForBananas = priceOfBananas * bananasNeeded;
            decimal moneyForEggs = priceOfEggs * eggsNeeded;
            decimal moneyForBerries = priceOFBerries * berriesNeeded;

            decimal combinedPrice = moneyForBananas + moneyForBerries + moneyForEggs;

            if (combinedPrice <= CashOfIvancho)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {combinedPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {(combinedPrice - CashOfIvancho):f2}lv more.");
            }


        }
    }
}
