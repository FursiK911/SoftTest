using System;
using NUnit.Framework;
using Moq;
using Lab_2.Project_Code;

namespace Lab_2.Test_Code
{
    [TestFixture]
    public class SignalTestMockWithMoq
    {
        [Test]
        public void SortAndFilterTest()
        {
            var mock = new Mock<IArrayProcessor>();
            double[] array = new double[] { 2, 1, 6, -2, 4, 8, -1, -3, 10, 11, 11, 15, 3 };
            Signal signal = new Signal(mock.Object, array);
            mock.Verify(r => r.SortAndFilter(array), Times.Once());
        }
    }
}
