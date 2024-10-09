using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTest
{
    public class Circle : IFigure
    {
        public double Radius { get; set; }
        

        public Circle(double radius)
        {
            Radius = radius;
        }
        public double Area => Math.PI * Math.Pow(Radius, 2);


    }
}
