using System;
using Lab_2.Project_Code;
using NUnit.Framework;
using Moq;

namespace Lab_2.Test_Code
{
    [TestFixture]
    public class SignalTestStubWithMoq
    {
        [Test]
        public void CalculateSumTest()
        {
            var stub = new Mock<IArrayProcessor>();
            double[] array = new double[] { 2, 1, 6, -2, 4, 8, -1, -3, 10, 11, 11, 15, 3 };
            stub.Setup(r => r.SortAndFilter(array)).Returns(new double[] { 15, 11, 10, 8, 6, 4, 3, 2, 1 });
            Signal signal = new Signal(stub.Object, array);
            Assert.AreEqual(60, signal.CalculateSum());
        }

        [Test]
        public void CalculateDiffTest()
        {
            var stub = new Mock<IArrayProcessor>();
            double[] array = new double[] { 2, 1, 6, -2, 4, 8, -1, -3, 10, 11, 11, 15, 3 };
            stub.Setup(r => r.SortAndFilter(array)).Returns(new double[] { 15, 11, 10, 8, 6, 4, 3, 2, 1 });
            Signal signal = new Signal(stub.Object, array);
            Assert.AreEqual(-30, signal.CalculateDiff());
        }

        [Test]
        public void CalculateAverageTest()
        {
            var stub = new Mock<IArrayProcessor>();
            double[] array = new double[] { 2, 1, 6, -2, 4, 8, -1, -3, 10, 11, 11, 15, 3 };
            stub.Setup(r => r.SortAndFilter(array)).Returns(new double[] { 15, 11, 10, 8, 6, 4, 3, 2, 1 });
            Signal signal = new Signal(stub.Object, array);
            Assert.AreEqual(6.67, signal.CalculateAverage(60));
        }
    }
}
