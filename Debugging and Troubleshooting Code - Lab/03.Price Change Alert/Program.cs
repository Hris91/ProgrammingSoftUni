using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Price_Change_Alert
{
    class Program
    {
        static void Main(string[] args)
        {
       
                int prices = int.Parse(Console.ReadLine());
                double threshold = double.Parse(Console.ReadLine());
                double lastPrice = double.Parse(Console.ReadLine());

                for (int i = 0; i < prices - 1; i++)
                {
                    double currentPrice = double.Parse(Console.ReadLine());
                    double difference = PercentsDifference(lastPrice, currentPrice);
                    bool isSignificantDifference = isThereADifference(difference, threshold);

                    string message = GetDifference(currentPrice, lastPrice, difference * 100, isSignificantDifference);

                    Console.WriteLine(message);

                    lastPrice = currentPrice;
                }            

        }

        private static string GetDifference(double currentPrice, double lastPrice, double difference, bool isSignificantDifference)
        {
            string priceChange = string.Empty;
            if (difference == 0)
            {
                priceChange = string.Format("NO CHANGE: {0}", currentPrice);
            }
            else if (!isSignificantDifference)
            {
                priceChange = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference);
            }
            else if (isSignificantDifference && (difference > 0))
            {
                priceChange = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference);
                           
            }
            else if (isSignificantDifference && (difference < 0))
                priceChange = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference);
            return priceChange;
        }

        private static bool isThereADifference(double threshold, double isDiff)
        {
            if (Math.Abs(threshold) >= isDiff)
            {
                return true;
            }
            return false;
        }

        private static double PercentsDifference(double lastPrice, double currentPrice)
        {
            double percentDifference = (currentPrice - lastPrice) / lastPrice;           
            return percentDifference;
        }
    }
}

