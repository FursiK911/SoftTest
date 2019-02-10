using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Project
{
    public class Triangle
    {
        private double a, b, c;

        public Triangle(double a, double b, double c)
        {
            if (CheckSides(a, b, c))
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
        }

        public void SetSides(double a, double b, double c)
        {
            if (CheckSides(a, b, c))
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
        }

        public double CalculateArea()
        {
            double halfPerimeter = (a + b + c) / 2;
            return Math.Round(Math.Sqrt(halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c)), 4);
        }

        private bool CheckSides(double a, double b, double c)
        {
            if (a < 1e-10 || b < 1e-10 || c < 1e-10)
                throw new FormatException("The parties should not be negative");
            if (a + b <= c || a + c <= b || b + c <= a)
                throw new ArgumentException("The sides cannot form a triangle");
            return true;
        }
    }
}
