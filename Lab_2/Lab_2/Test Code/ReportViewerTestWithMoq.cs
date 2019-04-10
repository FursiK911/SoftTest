using Lab_2.Project_Code;
using Moq;
using NUnit.Framework;
using System;

namespace Lab_2.Test_Code
{
    [TestFixture]
    public class ReportViewerTestWithMoq
    {
        [Test]
        public void RemoveTemporaryFilesMockTest()
        {
            var mock = new Mock<IFileService>();
            var reportViewer = new ReportViewer(mock.Object);
            reportViewer.Clean();
            mock.Verify(r => r.RemoveTemporaryFiles("Text.txt"), Times.Once());
        }

        [Test]
        public void RemoveTemporaryFilesStubTest()
        {
            var stub = new Mock<IFileService>();
            stub.Setup(r => r.RemoveTemporaryFiles("Text.txt")).Returns(1024);
            var reportViewer = new ReportViewer(stub.Object);
            reportViewer.Clean();
            Assert.AreEqual(reportViewer.UsedSize, 1024);
        }
    }
}
