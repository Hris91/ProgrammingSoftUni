using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Boxes
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }


        public  Point ReadPoint( string currentPointsAsString)
        {
            double[] PointParts = currentPointsAsString.Split(new []{':'},StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

            return new Point()
            {
                X = PointParts[0],
                Y = PointParts[1]
            };
        }   
    }
}
