using Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_Tests
{
    public class Triangle_Tests
    {
        [Fact]
        public void Triangle_TakesPositiveSides()
        {
            Triangle triangle = new Triangle(3, 4, 5);

            var result = triangle.Sides;

            Assert.NotNull(result);
            Assert.Equal(3, result[0]);
            Assert.Equal(4, result[1]);
            Assert.Equal(5, result[2]);
        }

        [Fact]
        public void Triangle_DontTakesZeroSide()
        {
            Triangle triangle = null;
            bool ok = false;

            try
            {
                triangle = new Triangle(0, 4, 5);
            }
            catch (Exception)
            {
                ok = true;
            }

            Assert.Null(triangle);
            Assert.True(ok);
        }

        [Fact]
        public void Triangle_DontTakesNegativeSide()
        {
            Triangle triangle = null;
            bool ok = false;

            try
            {
                triangle = new Triangle(3, -4, -5);
            }
            catch (Exception)
            {
                ok = true;
            }

            Assert.Null(triangle);
            Assert.True(ok);
        }

        [Fact]
        public void Triangle_DontTakesTooBigSide()
        {
            Triangle triangle = null;
            bool ok = false;

            try
            {
                triangle = new Triangle(3, 4, 8);
            }
            catch (Exception)
            {
                ok = true;
            }

            Assert.Null(triangle);
            Assert.True(ok);
        }

        [Fact]
        public void TrySetSide_TakesPositiveSides()
        {
            Triangle triangle = new Triangle(3, 4, 5);

            triangle.TrySetSide(0, 5);
            var result = triangle.Sides;

            Assert.NotNull(result);
            Assert.Equal(5, result[0]);
            Assert.Equal(4, result[1]);
            Assert.Equal(5, result[2]);
        }

        [Fact]
        public void TrySetSide_DontTakesIndexOutOfRange()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            bool ok = false;

            try
            {
                triangle.TrySetSide(-1, 10);
            }
            catch (Exception)
            {
                ok = true;
            }
            try
            {
                triangle.TrySetSide(3, 10);
            }
            catch (Exception)
            {
                ok = true;
            }
            var result = triangle.Sides;

            Assert.NotNull(result);
            Assert.Equal(3, result[0]);
            Assert.Equal(4, result[1]);
            Assert.Equal(5, result[2]);
            Assert.True(ok);
        }

        [Fact]
        public void TrySetSide_DontTakesZeroSide()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            bool ok = false;

            try
            {
                triangle.TrySetSide(1, 0);
            }
            catch (Exception)
            {
                ok = true;
            }
            var result = triangle.Sides;

            Assert.NotNull(result);
            Assert.Equal(3, result[0]);
            Assert.Equal(4, result[1]);
            Assert.Equal(5, result[2]);
            Assert.True(ok);
        }

        [Fact]
        public void TrySetSide_DontTakesNegativeSide()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            bool ok = false;

            try
            {
                triangle.TrySetSide(2, -5);
            }
            catch (Exception)
            {
                ok = true;
            }
            var result = triangle.Sides;

            Assert.NotNull(result);
            Assert.Equal(3, result[0]);
            Assert.Equal(4, result[1]);
            Assert.Equal(5, result[2]);
            Assert.True(ok);
        }

        [Fact]
        public void TrySetSide_DontTakesTooBigSide()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            bool ok = false;

            try
            {
                triangle.TrySetSide(2, 8);
            }
            catch (Exception)
            {
                ok = true;
            }
            var result = triangle.Sides;

            Assert.NotNull(result);
            Assert.Equal(3, result[0]);
            Assert.Equal(4, result[1]);
            Assert.Equal(5, result[2]);
            Assert.True(ok);
        }

        [Fact]
        public void GetArea_CanCalculateArea()
        {
            Triangle triangle = new Triangle(3, 4, 5);

            var result = triangle.GetArea();

            Assert.Equal(6, result, 0.000000000001);
        }

        [Fact]
        public void GetPerimeter_CanCalculatePerimeter()
        {
            Triangle triangle = new Triangle(3, 4, 5);

            var result = triangle.GetPerimeter();

            Assert.Equal(12, result, 0.000000000001);
        }

        [Fact]
        public void IsRight()
        {
            Triangle triangle = new Triangle(3, 4, 5);

            var result = triangle.IsRight();

            Assert.True(result);
        }

        [Fact]
        public void IsNotRight()
        {
            Triangle triangle = new Triangle(5, 5, 5);

            var result = triangle.IsRight();

            Assert.False(result);
        }
    }
}
