using System;
using Lab_2.Project_Code;
using NUnit.Framework;

namespace Lab_2.Test_Code
{
    [TestFixture]
    public class ReportViewerTest
    {
        [Test]
        public void RemoveTemporaryFilesStubTest()
        {
            var fileService = new FakeStubFileService();
            ReportViewer reportViewer = new ReportViewer(fileService);
            reportViewer.Clean();
            Assert.AreEqual(1024, reportViewer.UsedSize);
        }

        [Test]
        public void RemoveTemporaryFilesMockTest()
        {
            var fileService = new FakeMockFileService();
            ReportViewer reportViewer = new ReportViewer(fileService);
            reportViewer.Clean();
            Assert.That(fileService.RemoveTemporaryFilesCallsCount, Is.EqualTo(1));
        }
    }
}