using Lab_2.Project_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.Test_Code
{
    class FakeMockArrayProcessor : IArrayProcessor
    {
        public int PositiveValueCallsCount { get; set; }
        public int ReverseArrayCallsCount { get; set; }
        public int SortAndFilterCallsCount { get; set; }
        public int SortArrayCallsCount { get; set; }
        public int UniqueArrayCallsCount { get; set; }

        public double[] PositiveValue(double[] a)
        {
            PositiveValueCallsCount++;
            return a;
        }

        public double[] ReverseArray(double[] a)
        {
            ReverseArrayCallsCount++;
            return a;
        }

        public double[] SortAndFilter(double[] a)
        {
            PositiveValue(a);
            SortArray(a);
            ReverseArray(a);
            UniqueArray(a);
            SortAndFilterCallsCount++;
            return a;
        }

        public double[] SortArray(double[] a)
        {
            SortArrayCallsCount++;
            return a;
        }

        public double[] UniqueArray(double[] a)
        {
            UniqueArrayCallsCount++;
            return a;
        }
    }
}
