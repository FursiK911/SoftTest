using System;
using Lab_1_Project;
using NUnit.Framework;

namespace Lab_1_Test
{
    [TestFixture]
    public class ArrayProcessorTest
    {
        [Test]
        [TestCase(new double[] { 1, 2, 5, 9, 10 }, new double[] { -1, -2, -5, 9, 10 })]
        [TestCase(new double[] { 1, 2, 6, 9, 10 }, new double[] { 1, 2, -6, 9, -10 })]
        [TestCase(new double[] { 1, 2, 5, 9, 8 }, new double[] { -1, 2, 5, -9, 8 })]
        [TestCase(new double[] { 1, 2, 5, 9, 10 }, new double[] { -1, -2, -5, -9, -10 })]
        [TestCase(new double[] { 1, 2, 5, 9, 10, 20 }, new double[] { 1, 2, 5, 9, 10, -20 })]
        public void PositiveValue(double[] expectedResult, double[] obtainedResult)
        {
            ArrayProcessor arrayProcessor = new ArrayProcessor();
            CollectionAssert.AreEqual(expectedResult, arrayProcessor.PositiveValue(obtainedResult));
        }

        [Test]
        [TestCase(new double[] { 1, 2, 3, 4, 5, 15, 20 }, new double[] { 1, 4, 2, 5, 15, 20, 3 })]
        [TestCase(new double[] { 0, 4, 5, 6, 10, 11, 18 }, new double[] { 4, 5, 0, 6, 10, 18, 11 })]
        [TestCase(new double[] { 20, 22, 30, 49, 56 }, new double[] { 22, 49, 56, 30, 20 })]
        public void SortArray(double[] expectedResult, double[] obtainedResult)
        {
            ArrayProcessor arrayProcessor = new ArrayProcessor();
            CollectionAssert.AreEqual(expectedResult, arrayProcessor.SortArray(obtainedResult));
        }

        [Test]
        [TestCase(new double[] { 20, 15, 5, 4, 3, 2, 1 }, new double[] { 1, 2, 3, 4, 5, 15, 20 })]
        [TestCase(new double[] { 10, 8, 6, 4, 2, 0 }, new double[] { 0, 2, 4, 6, 8, 10 })]
        [TestCase(new double[] { 18, 17, 16 }, new double[] { 16, 17, 18 })]
        public void ReverseArray(double[] expectedResult, double[] obtainedResult)
        {
            ArrayProcessor arrayProcessor = new ArrayProcessor();
            CollectionAssert.AreEqual(expectedResult, arrayProcessor.ReverseArray(obtainedResult));
        }

        [Test]
        [TestCase(new double[] { 1, 3, 5, 20 }, new double[] { 1, 1, 3, 3, 5, 5, 20 })]
        [TestCase(new double[] { 20 }, new double[] { 20, 20, 20, 20, 20, 20 })]
        [TestCase(new double[] { 18, 17 }, new double[] { 18, 17, 18, 17 })]
        [TestCase(new double[] { 20, 14, 12, 10, 6, 2, 1 }, new double[] { 20, 20, 14, 12, 10, 10, 6, 6, 2, 1 })]
        public void UniqueValue(double[] expectedResult, double[] obtainedResult)
        {
            ArrayProcessor arrayProcessor = new ArrayProcessor();
            CollectionAssert.AreEqual(expectedResult, arrayProcessor.UniqueArray(obtainedResult));
        }
    }
}
