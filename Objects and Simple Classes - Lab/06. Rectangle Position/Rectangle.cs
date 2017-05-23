using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Rectangle_Position
{
    class Rectangle
    {
        public int Top { get; set; }

        public int Left { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public int Bottom
        {
            get { return Top + Height; }
        }

        public int Right
        {
            get { return Left + Width; }
        }

        public bool IsInside(Rectangle rectangle)
        {
            bool leftIsValid = rectangle.Left <= Left;
            bool topIsValid = rectangle.Top <= Top;
            bool rightIsValid = rectangle.Right >= Right;
            bool bottomIsValid = rectangle.Bottom >= Bottom;

            return leftIsValid && topIsValid && rightIsValid && bottomIsValid;
        }
    }
}
