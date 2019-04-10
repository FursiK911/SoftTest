using System;
using Lab_1_Project;
using NUnit.Framework;

namespace Lab_1_Test
{
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        [TestCase(-2.0, 1.0, 2.0)]
        [TestCase(2.0, -1.0, 2.0)]
        [TestCase(2.0, 1.0, -2.0)]
        public void NegativeSide(double a, double b, double c)
        {
            Assert.Throws<FormatException>(() =>  new Triangle(a, b, c));
        }

        [Test]
        [TestCase(5.0, 1.0, 2.0)]
        [TestCase(5.0, 2.0, 1.0)]
        [TestCase(1.0, 5.0, 2.0)]
        [TestCase(1.0, 2.0, 5.0)]
        [TestCase(2.0, 1.0, 5.0)]
        [TestCase(2.0, 5.0, 1.0)]
        public void TriangleNotExist(double a, double b, double c)
        { 
            Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
        }

        [Test]
        [TestCase(2.0, 3.0, 4.0)]
        [TestCase(2.0, 4.0, 3.0)]
        [TestCase(3.0, 2.0, 4.0)]
        [TestCase(3.0, 4.0, 2.0)]
        [TestCase(4.0, 3.0, 2.0)]
        [TestCase(4.0, 2.0, 3.0)]
        public void TestArea(double a, double b, double c)
        {
            Triangle triangle = new Triangle(a, b, c);
            Assert.AreEqual(2.9047, triangle.CalculateArea());
        }
    }
}
