using System;
using JetBrains.Annotations;

namespace MeasurableShapes.Shapes
{
    [PublicAPI]
    public struct Triangle : IMeasurableShape
    {
        private const double Precision = 0.00005;
        
        public double Area { get; }
        public bool IsRight { get; }

        public readonly double A;
        public readonly double B;
        public readonly double C;

        public Triangle(double a, double b, double c) : this()
        {
            if (a < 0 || b < 0 || c < 0) throw new ArgumentException("Arguments must be greater than or equal to zero.");
            if (a + b < c || a + c < b || b + c < a)
                throw new ArgumentException("A triangle with such sides cannot exist.");

            A = a;
            B = b;
            C = c;

            IsRight = Math.Abs(a * a + b * b - c * c) < Precision ||
                      Math.Abs(a * a + c * c - b * b) < Precision ||
                      Math.Abs(c * c + b * b - a * a) < Precision;
            Area = CalculateArea();
        }

        private double CalculateArea()
        {
            var perimeter = (A + B + C) / 2;
            return Math.Sqrt(perimeter * (perimeter - A) * (perimeter - B) * (perimeter - C));
        }
    }
}