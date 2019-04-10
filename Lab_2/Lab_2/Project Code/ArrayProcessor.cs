using Lab_2.Project_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.Test_Code
{
    public class ArrayProcessor : IArrayProcessor
    {
        public double[] SortAndFilter(double[] array)
        {
            double[] _newArray = array;
            _newArray = PositiveValue(_newArray);
            _newArray = SortArray(_newArray);
            _newArray = ReverseArray(_newArray);
            _newArray = UniqueArray(_newArray);
            return _newArray;
        }

        public double[] PositiveValue(double[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Math.Abs(a[i]);
            }
            return a;
        }

        public double[] SortArray(double[] a)
        {
            Array.Sort(a);
            return a;
        }

        public double[] ReverseArray(double[] a)
        {
            Array.Reverse(a);
            return a;
        }

        public double[] UniqueArray(double[] a)
        {
            a = a.Distinct().ToArray();
            return a;
        }
    }
}
