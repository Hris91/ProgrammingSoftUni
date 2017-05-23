using System;
using System.Linq;


namespace _04.Distance_between_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            Point firsPoint = ReadPoint();
            Point secondPoint = ReadPoint();
            double result = Distance(firsPoint, secondPoint);

            Console.WriteLine($"{result:f3}");

        }

        public static double Distance(Point first, Point second)
        {
            double squareX = Math.Pow(first.X - second.X, 2);
            double squareY = Math.Pow(first.Y - second.Y, 2);

            double result = Math.Sqrt(squareX + squareY);
            return result;
        }

        public static Point ReadPoint()
        {

            double[] PointParts = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            return new Point()
            {
                X = PointParts[0],
                Y = PointParts[1]
            };
        }
    }
}
