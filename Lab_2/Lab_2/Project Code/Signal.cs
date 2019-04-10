using Lab_2.Project_Code;
using Lab_2.Test_Code;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.Project_Code
{
    class Signal : ISignal
    {
        public double[] Samples { get; set; }

        public Signal(IArrayProcessor arrayProcessor, double[] array)
        {
            SetSamples(arrayProcessor, array);
        }

        public void SetSamples(IArrayProcessor arrayProcessor, double[] array)
        {
            Samples = arrayProcessor.SortAndFilter(array);
        }

        public void FullRectify()
        {
            double sum = CalculateSum();
            double diff = CalculateDiff();
            double average = CalculateAverage(sum);
            WriteToFile(sum, diff, average);
        }

        public void WriteToFile(double sum, double diff, double average)
        {
            for (int i = 0; i < Samples.Length; i++)
            {
                if(!File.Exists("results(" + i + ").txt"))
                {
                    using (StreamWriter sw = new StreamWriter("results(" + i + ").txt", false, System.Text.Encoding.Default))
                    {
                        sw.WriteLine(sum);
                        sw.WriteLine(diff);
                        sw.WriteLine(average);
                    }
                    break;
                }
            }
        }

        public double CalculateSum()
        {
            double sum = 0;

            for (int i = 0; i < Samples.Length; i++)
            {
                sum += Samples[i];
            }

            return sum;
        }

        public double CalculateDiff()
        {
            double diff = Samples[0];

            for (int i = 1; i < Samples.Length; i++)
            {
                diff -= Samples[i];
            }

            return diff;
        }

        public double CalculateAverage(double sum)
        {
            double average = sum / Samples.Length;

            return Math.Round(average, 2);
        }
    }
}
