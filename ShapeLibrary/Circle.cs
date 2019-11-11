using System;

namespace ShapeLibrary
{
    public class Circle : IShape
    {
        double r;
        public Circle(double radius)
        {
            if (radius <= 0) throw new ArgumentOutOfRangeException();
            r = radius;
        }

        public double GetArea()
        {
            return Math.PI * r * r;
        }
    }
}
