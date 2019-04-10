using System;
using Lab_2.Project_Code;
using NUnit.Framework;

namespace Lab_2.Test_Code
{
    [TestFixture]
    public class SignalTestStub
    {
        [Test]
        public void CalculateSumTest()
        {
            var arrayProcessor = new FakeStubArrayProcessor();
            Signal signal = new Signal(arrayProcessor, new double[] {2, 1, 6, -2, 4, 8, -1, -3, 10, 11, 11, 15, 3});
            Assert.AreEqual(60, signal.CalculateSum());
        }

        [Test]
        public void CalculateDiffTest()
        {
            var arrayProcessor = new FakeStubArrayProcessor();
            Signal signal = new Signal(arrayProcessor, new double[] { 2, 1, 6, -2, 4, 8, -1, -3, 10, 11, 11, 15, 3 });
            Assert.AreEqual(-30, signal.CalculateDiff());
        }

        [Test]
        public void CalculateAverageTest()
        {
           
            var arrayProcessor = new FakeStubArrayProcessor();
            Signal signal = new Signal(arrayProcessor, new double[] { 2, 1, 6, -2, 4, 8, -1, -3, 10, 11, 11, 15, 3 });
            Assert.AreEqual(6.67, signal.CalculateAverage(60));
        }
    }
}
