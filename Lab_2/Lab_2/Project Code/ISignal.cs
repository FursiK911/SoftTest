using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.Project_Code
{
    interface ISignal
    {
        void FullRectify();
        double CalculateSum();
        double CalculateDiff();
        double CalculateAverage(double sum);
        void WriteToFile(double sum, double diff, double average);
        void SetSamples(IArrayProcessor arrayProcessor, double[] array);
    }
}
