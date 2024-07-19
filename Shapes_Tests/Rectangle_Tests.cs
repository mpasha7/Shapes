using Shapes;
using System;
using ShapesClient;

namespace Shapes_Tests
{
    public class Rectangle_Tests
    {
        [Fact]
        public void Rectangle_TakesPositiveSides()
        {
            Rectangle rectangle = new Rectangle(2, 5);

            var result = rectangle.Sides;

            Assert.NotNull(result);
            Assert.Equal(2, result[0]);
            Assert.Equal(5, result[1]);
        }

        [Fact]
        public void Rectangle_DontTakesZeroSide()
        {
            Rectangle rectangle = null;
            bool ok = false;

            try
            {
                rectangle = new Rectangle(0, 5);
            }
            catch (Exception)
            {
                ok = true;
            }

            Assert.Null(rectangle);
            Assert.True(ok);
        }

        [Fact]
        public void Rectangle_DontTakesNegativeSide()
        {
            Rectangle rectangle = null;
            bool ok = false;

            try
            {
                rectangle = new Rectangle(2, -5);
            }
            catch (Exception)
            {
                ok = true;
            }

            Assert.Null(rectangle);
            Assert.True(ok);
        }

        [Fact]
        public void TrySetSide_TakesPositiveSides()
        {
            Rectangle rectangle = new Rectangle(2, 5);

            rectangle.TrySetSide(0, 8);
            var result = rectangle.Sides;

            Assert.NotNull(result);
            Assert.Equal(8, result[0]);
            Assert.Equal(5, result[1]);
        }

        [Fact]
        public void TrySetSide_DontTakesIndexOutOfRange()
        {
            Rectangle rectangle = new Rectangle(2, 5);
            bool ok = false;

            try
            {
                rectangle.TrySetSide(-1, 10);
            }
            catch (Exception)
            {
                ok = true;
            }
            try
            {
                rectangle.TrySetSide(2, 10);
            }
            catch (Exception)
            {
                ok = true;
            }
            var result = rectangle.Sides;

            Assert.NotNull(result);
            Assert.Equal(2, result[0]);
            Assert.Equal(5, result[1]);
            Assert.True(ok);
        }

        [Fact]
        public void TrySetSide_DontTakesZeroSide()
        {
            Rectangle rectangle = new Rectangle(2, 5);
            bool ok = false;

            try
            {
                rectangle.TrySetSide(1, 0);
            }
            catch (Exception)
            {
                ok = true;
            }
            var result = rectangle.Sides;

            Assert.NotNull(result);
            Assert.Equal(2, result[0]);
            Assert.Equal(5, result[1]);
            Assert.True(ok);
        }

        [Fact]
        public void TrySetSide_DontTakesNegativeSide()
        {
            Rectangle rectangle = new Rectangle(2, 5);
            bool ok = false;

            try
            {
                rectangle.TrySetSide(1, -2);
            }
            catch (Exception)
            {
                ok = true;
            }
            var result = rectangle.Sides;

            Assert.NotNull(result);
            Assert.Equal(2, result[0]);
            Assert.Equal(5, result[1]);
            Assert.True(ok);
        }

        [Fact]
        public void GetArea_CanCalculateArea()
        {
            Rectangle rectangle = new Rectangle(10, 5);

            var result = rectangle.GetArea();

            Assert.Equal(50, result, 0.000000000001);
        }

        [Fact]
        public void GetPerimeter_CanCalculatePerimeter()
        {
            Rectangle rectangle = new Rectangle(2, 8);

            var result = rectangle.GetPerimeter();

            Assert.Equal(20, result, 0.000000000001);
        }

        [Fact]
        public void IsRight()
        {
            Rectangle rectangle = new Rectangle(6, 6);

            var result = rectangle.IsSquare();

            Assert.True(result);
        }

        [Fact]
        public void IsNotRight()
        {
            Rectangle rectangle = new Rectangle(2, 8);

            var result = rectangle.IsSquare();

            Assert.False(result);
        }
    }
}
