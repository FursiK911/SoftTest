using Lab_2.Project_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.Test_Code
{
    class FakeStubFileService : IFileService
    {
        public long RemoveTemporaryFiles(string dir)
        {
            return 1024;
        }
    }
}
