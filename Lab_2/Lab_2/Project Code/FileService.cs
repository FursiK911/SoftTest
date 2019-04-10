using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.Project_Code
{
    class FileService : IFileService
    {
        public long RemoveTemporaryFiles(string dir)
        {
            if (File.Exists(dir + "\\ToRemove.txt"))
                throw new DirectoryNotFoundException();

            long sizeFiles = 0;
            using (StreamReader sr = new StreamReader(dir + "\\ToRemove.txt"))
            {
                while(!sr.EndOfStream)
                {
                    string dirFile = sr.ReadLine();
                    if (File.Exists(dir + "\\ToRemove.txt"))
                    {
                        FileInfo file = new FileInfo(dirFile);
                        sizeFiles += file.Length;
                        File.Delete(dirFile);
                    } 
                    else
                    {
                        using (StreamWriter sw = new StreamWriter("error.log", true))
                        {
                            sw.WriteLine("Файл " + dirFile + " не был найден");
                        }
                    }
                }  
            }

            return sizeFiles;
        }
    }
}