using Lab_2.Project_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.Test_Code
{
    class FakeStubArrayProcessor : IArrayProcessor
    {
        public double[] SortAndFilter(double[] a)
        {
            return new double[] { 15, 11, 10, 8, 6, 4, 3, 2, 1 };
        }

        public double[] SortArray(double[] a)
        {
            return new double[] { 1, 1, 2, 2, 3, 3, 4, 6, 8, 10, 11, 11, 15 };
        }

        public double[] PositiveValue(double[] a)
        {
            return new double[] { 2, 1, 6, 2, 4, 8, 1, 3, 10, 11, 11, 15, 3 };
        }

        public double[] ReverseArray(double[] a)
        {
            return new double[] { 15, 11, 11, 10, 8, 6, 4, 3, 3, 2, 2, 1, 1 };
        }

        public double[] UniqueArray(double[] a)
        {
            return new double[] { 15, 11, 10, 8, 6, 4, 3, 2, 1};
        }
    }
}
