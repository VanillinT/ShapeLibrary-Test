using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeLibrary
{
    public class Triangle : IShape
    {
        double a, b, c;
        public Triangle(double side1, double side2, double side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0) throw new ArgumentOutOfRangeException();

            a = side1;
            b = side2;
            c = side3;
        }

        public double GetArea()
        {
            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }
    }
}
