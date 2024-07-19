using Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesClient
{
    /// <summary>
    /// Прямоугольник
    /// </summary>
    public class Rectangle : Polygon
    {
        /// <summary>
        /// Инициирует объект класса Rectangle по трем его сторонам
        /// </summary>
        /// <param name="a">1-я сторона прямоугольника</param>
        /// <param name="b">2-я сторона прямоугольника</param>
        /// <exception cref="ArgumentException"></exception>
        public Rectangle(double a, double b)
        {
            if (a <= 0 || b <= 0)
            {
                throw new ArgumentException("Аргумент должен быть положительным числом!");
            }
            Sides = new double[2];
            Sides[0] = a;
            Sides[1] = b;
        }

        /// <summary>
        /// Вычисляет периметр прямольника
        /// </summary>
        /// <returns>Периметр прямольника</returns>
        public override double GetPerimeter()
        {
            return base.GetPerimeter() * 2;
        }

        /// <summary>
        /// Вычисляет площадь прямольника
        /// </summary>
        /// <returns>Площадь прямольника</returns>
        public override double GetArea()
        {
            return Sides[0] * Sides[1];
        }

        /// <summary>
        /// Является ли прямоугольник квадратом
        /// </summary>
        /// <returns></returns>
        public bool IsSquare()
        {
            return Math.Abs(Sides[0] - Sides[1]) < 0.000000000001;
        }

        /// <summary>
        /// Пытается установить размер заданной стороны прямоугольника
        /// </summary>
        /// <param name="index">Номер стороны прямоугольника</param>
        /// <param name="value">Новый размер стороны прямоугольника</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public override void TrySetSide(int index, double value)
        {
            if (index < 0 || index > Sides.Length)
            {
                throw new ArgumentOutOfRangeException("index");
            }
            if (value <= 0)
            {
                throw new ArgumentException("Аргумент должен быть положительным числом!", nameof(value));
            }
            Sides[index] = value;
        }
    }
}
