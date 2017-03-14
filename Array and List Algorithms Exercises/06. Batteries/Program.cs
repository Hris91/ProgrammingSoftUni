using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Batteries
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] batteryCapacitie = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double[] usagePerHour = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int avaliableHours = int.Parse(Console.ReadLine());

            for (int i = 0; i < batteryCapacitie.Length; i++)
            {
                int batteryCounter = i+1;
                double currentBattery = batteryCapacitie[i];
                double currentUsage = usagePerHour[i];
                double batteryStatus = currentBattery - (currentUsage * avaliableHours);
                double hoursLasted = Math.Ceiling(currentBattery / currentUsage);

                if (batteryStatus <= 0)
                {
                    Console.WriteLine($"Battery {batteryCounter}: dead (lasted {hoursLasted} hours)");
                }
                else 
                {
                    double remainingPercentage = (batteryStatus / batteryCapacitie[i]) * 100;
                    Console.WriteLine($"Battery {batteryCounter}: {batteryStatus:f2} mAh ({remainingPercentage:f2})%");
                }
                        
            }
        }
    }
}
