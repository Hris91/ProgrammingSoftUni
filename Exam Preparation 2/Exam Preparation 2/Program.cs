using System;


namespace Exam_Preparation_2
{
    class Program
    {
        static void Main(string[] args)
        {
            long lengthInDays = int.Parse(Console.ReadLine());
            long numberOfRunners = int.Parse(Console.ReadLine());
            long avarageNumberOfLaps = int.Parse(Console.ReadLine());
            long lenghtOfTheTrack = int.Parse(Console.ReadLine());
            long capacityOfTheTrack = int.Parse(Console.ReadLine());
            decimal amauntOfmoneyPerKillometer = decimal.Parse(Console.ReadLine());

            long maximumRunners = capacityOfTheTrack * lengthInDays;

            if (numberOfRunners > maximumRunners)
            {
                numberOfRunners = maximumRunners;
            }
            
            long totalKillometers = (numberOfRunners * avarageNumberOfLaps * lenghtOfTheTrack) / 1000;
           
            decimal totalMoneyRaised = ((decimal)totalKillometers * amauntOfmoneyPerKillometer);

            Console.WriteLine($"Money raised: {totalMoneyRaised:f2}");
        }
    }
}
