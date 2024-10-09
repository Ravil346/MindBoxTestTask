using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTest
{
    public class Triangle : IFigure
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }


        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double Area
        {
            get
            {
                double semip = (A + B + C) / 2;
                return Math.Sqrt(semip * (semip - A) * (semip - B) * (semip - C));
            }
        }

        public bool IsRectangular()
        {
            return Math.Pow(A, 2) == (Math.Pow(B, 2) + Math.Pow(C, 2)) || Math.Pow(B, 2) == (Math.Pow(A, 2) + Math.Pow(C, 2)) || Math.Pow(C, 2) == (Math.Pow(B, 2) + Math.Pow(A, 2));
            
        }
    }
}
