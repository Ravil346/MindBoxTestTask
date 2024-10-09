using MindBoxTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTestTests
{
    public class TriangleTests
    {
        [Fact]
        public void AreaTriangle_5and3and4_6returned()
        {
            //входные данные
            int a = 5, b = 3, c = 4;
            double expected = 6;

            // действие

            Triangle triangle = new Triangle(a, b, c);
            double actual = triangle.Area;

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsRectangular_5and3and4_Truereturned()
        {
            int a = 5, b = 3, c = 4;
            bool expected = true;
            Triangle triangle = new Triangle(a, b, c);
            bool actual = triangle.IsRectangular();

            Assert.Equal(expected, actual);

        }
    }
}
