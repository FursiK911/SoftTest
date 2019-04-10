using Lab_2.Project_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.Test_Code
{
    class FakeMockFileService : IFileService
    {
        public int RemoveTemporaryFilesCallsCount { get; set; }

        public long RemoveTemporaryFiles(string dir)
        {
            RemoveTemporaryFilesCallsCount++;
            return 0;
        }
    }
}
