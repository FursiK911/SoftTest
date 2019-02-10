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

            for (int i = path.Length - 1; i > 0; i--) // Выделяем короткое имя
            {
                if (path[i] == '\\')
                {
                    path = path.Substring(i + 1);
                    break;
                }
            }

            for (int i = path.Length - 1; i > 0; i--) // Выделяем расширение
            {
                if (path[i] == '.')
                {
                    path = path.Substring(0, i);
                    break;
                }
            }

            path += ".tmp";
            path = path.ToUpper();
            return path;
        }
    }
}
