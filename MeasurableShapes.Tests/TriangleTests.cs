using System;
using FluentAssertions;
using MeasurableShapes.Shapes;
using NUnit.Framework;

namespace MeasurableShapes.Tests
{
    public class TriangleTests
    {
        [TestCase(3, 3, 6, 0)]
        [TestCase(3, 4, 5, 6)]
        [TestCase(14, 13, 15, 84)]
        public void Should_correctly_calculate_area(double a, double b, double c, double expected)
        {
            var triangle = new Triangle(a, b, c);

            triangle.Area.Should().BeApproximately(expected, 0.0005);
        }

        [TestCase(3, 4, 5, true)]
        [TestCase(3, 3, 3, false)]
        public void Should_correctly_define_right_triangle(double a, double b, double c, bool expected)
        {
            var triangle = new Triangle(a, b, c);

            triangle.IsRight.Should().Be(expected);
        }

        [Test]
        public void Should_throw_exception_on_negative_sides()
        {
            var throwable = () => new Triangle(-2, 1, 1);

            throwable.Should().Throw<ArgumentException>();
        }

        [Test]
        public void Should_throw_exception_on_non_existent_triangle()
        {
            var throwable = () => new Triangle(1, 1, 10);

            throwable.Should().Throw<ArgumentException>();
        }
    }
}