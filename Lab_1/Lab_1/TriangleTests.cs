using System;
using Lab_1_Project;
using NUnit.Framework;

namespace Lab_1_Test
{
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void NegativeSide()
        {
            Assert.Throws<FormatException>(() =>  new Triangle(-2.0, 1.0, 2.0));
        }

        [Test]
        public void TriangleNotExist()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(5.0, 1.0, 2.0));
        }

        [Test]
        public void TestArea()
        {
            Triangle triangle = new Triangle(2.0, 3.0, 4.0);
            Assert.AreEqual(2.9047, triangle.CalculateArea());
        }
    }
}
