using System;

namespace RectangleTest
{
    class Rectangle
    {
        private double length = 1;
        private double width = 1;
        // private double perimeter;
        // private double area;

        public Rectangle(double length, double breadth){
            Length = length;
            Width = width;
        }
        

        public double Length
        {
            get { return length; }
            set
            {
                if(value > 0.0 && value < 20.0)
                {
                    length = value;
                }

            }
        }
        public double Width
        {
            get { return width; }
            set
            {
                if (value > 0.0 && value < 20.0)
                {
                    width = value;
                }

            }
        }

        
        public double getArea()
        {
           double Area = Length * Width;
           return Area;
        }

        public override string ToString()
        {
            return $"Length: {Length} Width: {Width} Area: {getArea()}";
        }

    }
}
