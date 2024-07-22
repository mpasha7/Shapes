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
        /// Инициирует объект класса Rectangle по его ширине и высоте
        /// </summary>
        /// <param name="a">Ширина прямоугольника</param>
        /// <param name="b">Высота прямоугольника</param>
        /// <exception cref="ArgumentException"></exception>
        public Rectangle(double a, double b) : base(a, b) { }

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
        /// Проверяет, является ли прямоугольник квадратом
        /// </summary>
        /// <returns></returns>
        public bool IsSquare()
        {
            return Math.Abs(Sides[0] - Sides[1]) < 0.000000000001;
        }

        /// <summary>
        /// Проверка возможности создания прямоугольника по заданным сторонам
        /// </summary>
        /// <param name="sides">Массив размеров сторон прямоугольника</param>
        /// <exception cref="ArgumentException"></exception>
        protected override void CheckSides(params double[] sides)
        {
            foreach (double side in sides)
            {
                if (side <= 0)
                    throw new ArgumentException("Аргумент должен быть положительным числом!", nameof(side));
            }
        }

        /// <summary>
        /// Проверка возможности изменения размера стороны прямоугольника
        /// </summary>
        /// <param name="index">Номер стороны</param>
        /// <param name="value">Новый размер стороны</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="ArgumentException"></exception>
        protected override void CheckSide(int index, double value)
        {
            if (index < 0 || index >= Sides.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }
            if (value <= 0)
            {
                throw new ArgumentException($"Аргумент должен быть положительным числом!", nameof(value));
            }
        }
    }
}
