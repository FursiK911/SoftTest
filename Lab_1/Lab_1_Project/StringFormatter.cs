using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Project
{
    public class StringFormatter
    {
        public string ShortFileString(string path)
        {
            if (path == "")
                return path;
            else if (path == null)
                throw new NullReferenceException("The string has no reference");

            path = SelectShortName(path);
            path = SelectExpansion(path);
            path = UpperString(path);

            return path;
        }

        public string SelectShortName(string fullName)
        {
            string shortName = null;

            for (int i = fullName.Length - 1; i > 0; i--) // Выделяем короткое имя
            {
                if (fullName[i] == '\\')
                {
                    shortName = fullName.Substring(i + 1);
                    break;
                }
            }

            return shortName;
        }

        public string SelectExpansion(string fileName)
        {
            string nameWithExpansion = null;

            for (int i = fileName.Length - 1; i > 0; i--) // Выделяем расширение
            {
                if (fileName[i] == '.')
                {
                    nameWithExpansion = fileName.Substring(0, i);
                    break;
                }
            }

            nameWithExpansion += ".tmp";
            return nameWithExpansion;
        }

        public string UpperString(string fileName)
        {
            fileName = fileName.ToUpper();
            return fileName;
        }
    }
}
