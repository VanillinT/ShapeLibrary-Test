using System;
using Xunit;
using ShapeLibrary;

namespace ShapeLibraryTests
{
    public class Tests
    {
        [Fact]
        public void TestCircleAccuracy()
        {
            double r = 5.123, expectedVal = Math.PI * r * r;
            Assert.Equal(expectedVal, new Circle(r).GetArea());
        }

        [Fact]
        public void TestCircleArgumentRange()
        {
            double r1 = 0;
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(r1));

            double r2 = -2.324;
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(r2));
        }

        [Fact]
        public void TestTriangleAccuracy()
        {
            double a = 3, b = 5, c = 5.4;
            double s = (a + b + c) / 2;

            double expectedVal = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            Assert.Equal(expectedVal, new Triangle(a,b,c).GetArea());
        }

        [Fact]
        public void TestTriangleArgumentRange()
        {
            double a = 1, b = 2, c = 0;
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(a,b,c));

            a = -1; b = -2; c = 5;
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(a, b, c));
        }

        [Fact]
        public void TestTriangleIsRight()
        {
            double a = 5, b = 4, c = 3;
            Assert.True(new Triangle(a, b, c).IsRight);
            Assert.True(new Triangle(c, b, a).IsRight);


            a = 5; b = 10; c = 20;
            Assert.False(new Triangle(a, b, c).IsRight);
        }
    }
}
