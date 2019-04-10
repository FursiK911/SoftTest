using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.Project_Code
{
    class ReportViewer
    {
        public long UsedSize { get; set; }
        public IFileService FileService { get; set; }

        public ReportViewer(IFileService fileService)
        {
            SetFileService(fileService);
        }

        public void SetFileService(IFileService fileService)
        {
            FileService = fileService;
        }

        public void Clean()
        {
            try
            {
                UsedSize = FileService.RemoveTemporaryFiles("Text.txt");
            }
            catch
            {
                return;
            }
        }
    }
}
