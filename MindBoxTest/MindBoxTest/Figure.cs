using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTest
{
    public class Figure : IFigure
    {
        public IFigure figure;
        public double Area => figure.Area;

        public Figure(IFigure figure)
        {
            this.figure = figure;

        }
    }
}
