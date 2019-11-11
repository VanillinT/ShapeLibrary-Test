using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeLibrary
{
    public class Triangle : IShape
    {
        //a is presumably a hypotenuse
        double a, b, c;
        public bool IsRight { get; private set; }

        public Triangle(double side1, double side2, double side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0) throw new ArgumentOutOfRangeException();

            //assigning the longest side to variable 'a'
            if (side1 >= side2 && side1 >= side3) { a = side1;  b = side2; c = side3; }
            else if (side2 >= side1 && side2 >= side3) { a = side2; b = side1; c = side3; }
            else { a = side3; b = side1; c = side2; }

            IsRight = a * a == b * b + c * c;
        }



        public double GetArea()
        {
            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

    }
}
