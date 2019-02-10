using System;
using Lab_1_Project;
using NUnit.Framework;

namespace Lab_1_Test
{
    [TestFixture]
    public class ArrayProcessorTest
    {
        [Test]
        public void PositiveValue()
        {
            ArrayProcessor arrayProcessor = new ArrayProcessor();
            CollectionAssert.AreEqual(new double[] { 1, 2, 5, 9, 10 }, arrayProcessor.SortAndFilter(new double[] { -1, -2, -5, 9, 10}));
        }

        [Test]
        public void UniqueValue()
        {
            ArrayProcessor arrayProcessor = new ArrayProcessor();
            CollectionAssert.AreEqual(new double[] { 1, 2, 3, 4, 5, 7, 10 }, arrayProcessor.SortAndFilter(new double[] { 1, 1, 2, 3, 3, 4, 4, 5, 7, 7, 10 }));
        }
    }
}
