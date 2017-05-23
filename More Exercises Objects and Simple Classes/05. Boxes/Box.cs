using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Boxes
{
    class Box
    {
        public Point UpperLeft  { get; set; }
        public Point UpperRight { get; set; }
        public Point BottomLeft { get; set; }
        public Point BottomRigh { get; set; }

        public double CalculatePerimeter(double width, double height)
        {
            return 2 * width + 2 * height;
        }

        public double CalculateArea(double width, double heigh)
        {
            return width * heigh;
        }
    }
}
