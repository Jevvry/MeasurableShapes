using System;
using FluentAssertions;
using MeasurableShapes.Shapes;
using NUnit.Framework;

namespace MeasurableShapes.Tests
{
    public class CircleTests
    {
        [TestCase(1, Math.PI)]
        [TestCase(0, 0)]
        [TestCase(2, 4 * Math.PI)]
        [TestCase(2.15, 2.15 * 2.15 * Math.PI)]
        public void Should_correctly_calculate_area(double radius, double expected)
        {
            var circle = new Circle(radius);

            circle.Area.Should().BeApproximately(expected, 0.0005);
        }
        
        [Test]
        public void Should_throw_exception_on_negative_radius()
        {
            var throwable = () => new Circle(-2);

            throwable.Should().Throw<ArgumentException>();
        }
    }
}