using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfBoxes = new List<Box>();
            string line = Console.ReadLine();

            while (line != "end")
            {
                string[] tokens = line.Split(new[] {' ', '|'}, StringSplitOptions.RemoveEmptyEntries).ToArray();
                Box currentBox = new Box();
                
                currentBox.UpperLeft = new Point();
                currentBox.UpperLeft = currentBox.UpperLeft.ReadPoint(tokens[0]);

                currentBox.UpperRight = new Point();
                currentBox.UpperRight = currentBox.UpperRight.ReadPoint(tokens[1]);

                currentBox.BottomLeft = new Point();
                currentBox.BottomLeft = currentBox.BottomLeft.ReadPoint(tokens[2]);

                currentBox.BottomRigh = new Point();
                currentBox.BottomRigh = currentBox.BottomRigh.ReadPoint(tokens[3]);

                listOfBoxes.Add(currentBox);
                
                line = Console.ReadLine();
            }

            foreach (var box in listOfBoxes)
            {
                double width = CalculateDistance(box.UpperLeft, box.UpperRight);
                double height = CalculateDistance(box.UpperLeft, box.BottomLeft);

                Console.WriteLine($"Box: {width}, {height}");
                Console.WriteLine($"Perimeter: {box.CalculatePerimeter(width, height)}");
                Console.WriteLine($"Area: {box.CalculateArea(width, height)}");
            }

        }
        public static double CalculateDistance(Point first, Point second)
        {
            double squareX = Math.Pow(first.X - second.X, 2);
            double squareY = Math.Pow(first.Y - second.Y, 2);

            double result = Math.Sqrt(squareX + squareY);

            return result;
        }
    }
}
