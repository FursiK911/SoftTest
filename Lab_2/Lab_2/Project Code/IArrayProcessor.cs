using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.Project_Code
{
    public interface IArrayProcessor
    {
        double[] SortAndFilter(double[] a);
        double[] PositiveValue(double[] a);
        double[] SortArray(double[] a);
        double[] ReverseArray(double[] a);
        double[] UniqueArray(double[] a);
    }
}
