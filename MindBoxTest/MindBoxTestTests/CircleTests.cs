using MindBoxTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTestTests
{
    public class CircleTests
    {
        [Fact]
        public void AreaCircle_2_int12returned()
        {
            //входные данные
            double r = 2;
            int expected = 12;

            // действие

            Circle circle = new Circle(r);
            double actual = circle.Area;

            // assert
            Assert.Equal(expected, (int)actual);
            
        }
    }
}
