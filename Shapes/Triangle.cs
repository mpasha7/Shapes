using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    /// <summary>
    /// Треугольник
    /// </summary>
    public class Triangle : Polygon
    {
        /// <summary>
        /// Инициирует объект класса Triangle по трем его сторонам
        /// </summary>
        /// <param name="a">1-я сторона треугольника</param>
        /// <param name="b">2-я сторона треугольника</param>
        /// <param name="c">3-я сторона треугольника</param>
        /// /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public Triangle(double a, double b, double c) : base(a, b, c) { }

        /// <summary>
        /// Вычисляет площадь треугольника
        /// </summary>
        /// <returns>Площадь треугольника</returns>
        public override double GetArea()
        {
            double p = GetPerimeter() / 2;
            return Math.Sqrt(p * (p - Sides[0]) * (p - Sides[1]) * (p - Sides[2]));
        }

        /// <summary>
        /// Является ли треугольник прямоугольным
        /// </summary>
        /// <returns></returns>
        public bool IsRight()
        {
            double[] sides = Sides.ToArray();
            Array.Sort(sides);
            return Math.Abs(sides[0] * sides[0] + sides[1] * sides[1] - sides[2] * sides[2]) < 0.000000000001;
        }

    }
}
