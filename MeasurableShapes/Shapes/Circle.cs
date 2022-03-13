using System;
using JetBrains.Annotations;

namespace MeasurableShapes.Shapes
{
    [PublicAPI]
    public struct Circle : IMeasurableShape
    {
        public double Area { get; }

        public readonly double Radius;

        public Circle(double radius) : this()
        {
            if (radius < 0) throw new ArgumentException("Arguments must be greater than or equal to zero.");
            
            Radius = radius;

            Area = Math.PI * Radius * Radius;
        }
    }
}