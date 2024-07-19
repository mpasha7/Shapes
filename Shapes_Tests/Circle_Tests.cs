using Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_Tests
{
    public class Circle_Tests
    {
        [Fact]
        public void Circle_TakesPositiveRadius()
        {
            Circle circle = new Circle(1);

            var result = circle.Radius;

            Assert.Equal(1, result);
        }

        [Fact]
        public void Circle_DontTakesZeroRadius()
        {
            Circle circle = null;
            bool ok = false;

            try
            {
                circle = new Circle(0);
            }
            catch (Exception)
            {
                ok = true;
            }

            Assert.Null(circle);
            Assert.True(ok);
        }

        [Fact]
        public void Circle_DontTakesNegativeRadius()
        {
            Circle circle = null;
            bool ok = false;

            try
            {
                circle = new Circle(-1);
            }
            catch (Exception)
            {
                ok = true;
            }

            Assert.Null(circle);
            Assert.True(ok);
        }

        [Fact]
        public void SetRadius_TakesPositiveRadius()
        {
            Circle circle = new Circle(1);

            circle.SetRadius(2);
            var result = circle.Radius;

            Assert.Equal(2, result);
        }

        [Fact]
        public void SetRadius_DontTakesZeroRadius()
        {
            Circle circle = new Circle(1);
            bool ok = false;

            try
            {
                circle.SetRadius(0);
            }
            catch (Exception)
            {
                ok = true;
            }
            var result = circle.Radius;

            Assert.Equal(1, result);
            Assert.True(ok);
        }

        [Fact]
        public void SetRadius_DontTakesNegativeRadius()
        {
            Circle circle = new Circle(1);
            bool ok = false;

            try
            {
                circle.SetRadius(-1);
            }
            catch (Exception)
            {
                ok = true;
            }
            var result = circle.Radius;

            Assert.Equal(1, result);
            Assert.True(ok);
        }

        [Fact]
        public void GetArea_CanCalculateArea()
        {
            Circle circle = new Circle(10);

            var result = circle.GetArea();

            Assert.Equal(100*Math.PI, result, 0.000000000001);
        }

        [Fact]
        public void GetPerimeter_CanCalculatePerimeter()
        {
            Circle circle = new Circle(10);

            var result = circle.GetPerimeter();

            Assert.Equal(20 * Math.PI, result, 0.000000000001);
        }
    }
}
