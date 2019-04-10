using System;
using Lab_2.Project_Code;
using NUnit.Framework;

namespace Lab_2.Test_Code
{
    [TestFixture]
    public class SignalTestMock
    {
        [Test]
        public void PositiveValueTest()
        {
            var arrayProcessor = new FakeMockArrayProcessor();
            Signal signal = new Signal(arrayProcessor, new double[] { 2, 1, 6, -2, 4, 8, -1, -3, 10, 11, 11, 15, 3 });
            Assert.That(arrayProcessor.PositiveValueCallsCount, Is.EqualTo(1));
        }

        [Test]
        public void ReverseArrayTest()
        {
            var arrayProcessor = new FakeMockArrayProcessor();
            Signal signal = new Signal(arrayProcessor, new double[] { 2, 1, 6, -2, 4, 8, -1, -3, 10, 11, 11, 15, 3 });
            Assert.That(arrayProcessor.ReverseArrayCallsCount, Is.EqualTo(1));
        }

        [Test]
        public void SortAndFilterTest()
        {
            var arrayProcessor = new FakeMockArrayProcessor();
            Signal signal = new Signal(arrayProcessor, new double[] { 2, 1, 6, -2, 4, 8, -1, -3, 10, 11, 11, 15, 3 });
            Assert.That(arrayProcessor.SortAndFilterCallsCount, Is.EqualTo(1));
        }

        [Test]
        public void SortArrayTest()
        {
            var arrayProcessor = new FakeMockArrayProcessor();
            Signal signal = new Signal(arrayProcessor, new double[] { 2, 1, 6, -2, 4, 8, -1, -3, 10, 11, 11, 15, 3 });
            Assert.That(arrayProcessor.SortArrayCallsCount, Is.EqualTo(1));
        }

        [Test]
        public void UniqueArrayTest()
        {
            var arrayProcessor = new FakeMockArrayProcessor();
            Signal signal = new Signal(arrayProcessor, new double[] { 2, 1, 6, -2, 4, 8, -1, -3, 10, 11, 11, 15, 3 });
            Assert.That(arrayProcessor.UniqueArrayCallsCount, Is.EqualTo(1));
        }
        
    }
}