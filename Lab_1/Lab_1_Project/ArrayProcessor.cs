using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Project
{
    public class ArrayProcessor
    {
        public double[] SortAndFilter(double[] a)
        {
            double[] _newArray = new double[a.Length];

            for (int i = 0; i < _newArray.Length; i++)
            {
                _newArray[i] = Math.Abs(a[i]);
            }

            Array.Sort(_newArray);
            _newArray.Reverse();

            List<double> tmpList = _newArray.ToList();

            for (int i = 0; i < tmpList.Count - 1; i++)
            {
                if (tmpList[i] == tmpList[i + 1])
                {
                    tmpList.RemoveAt(i + 1);
                }
            }
            _newArray = tmpList.ToArray();

            return _newArray;
        }
    }
}
