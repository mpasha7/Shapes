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
            Assert.Throws<ArgumentException>(() => { Rectangle rectangle = new Rectangle(0, 5); });
        }

        [Fact]
        public void Rectangle_DontTakesNegativeSide()
        {
            Assert.Throws<ArgumentException>(() => { Rectangle rectangle = new Rectangle(2, -5); });
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
            Assert.Throws<ArgumentOutOfRangeException>(() => { rectangle.TrySetSide(-1, 5); });
            Assert.Throws<ArgumentOutOfRangeException>(() => { rectangle.TrySetSide(2, 5); });
        }

        [Fact]
        public void TrySetSide_DontTakesZeroSide()
        {
            Rectangle rectangle = new Rectangle(1, 1);
            Assert.Throws<ArgumentException>(() => { rectangle.TrySetSide(1, 0); });
        }

        [Fact]
        public void TrySetSide_DontTakesNegativeSide()
        {
            Rectangle rectangle = new Rectangle(2, 5);
            Assert.Throws<ArgumentException>(() => { rectangle.TrySetSide(1, -2); });
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
