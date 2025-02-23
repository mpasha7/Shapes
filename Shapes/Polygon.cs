﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    /// <summary>
    /// Многоугольник
    /// </summary>
    public abstract class Polygon : IShape
    {
        /// <summary>
        /// Массив сторон многоугольника
        /// </summary>
        public List<double> Sides { get; protected set; }

        /// <summary>
        /// Инициирует объект класса Polygon по его сторонам (абстрактно)
        /// </summary>
        /// <param name="sides">Стороны многоугольника</param>
        /// <exception cref="ArgumentException"></exception>
        protected Polygon(params double[] sides)
        {
            try
            {
                CheckSides(sides);
                Sides = new List<double>(sides);
            }
            catch (ArgumentException)
            {
                throw;
            }
        }

        /// <summary>
        /// Возвращает площадь многоугольника
        /// </summary>
        /// <returns>Площадь многоугольника</returns>
        public abstract double GetArea();

        /// <summary>
        /// Возвращает периметр многоугольника
        /// </summary>
        /// <returns>Периметр многоугольника</returns>
        public virtual double GetPerimeter()
        {
            return Sum(Sides, 0);
        }

        /// <summary>
        /// Пытается установить размер заданной стороны многоугольника
        /// </summary>
        /// <param name="index">Номер стороны многоугольника</param>
        /// <param name="value">Новый размер стороны многоугольника</param>
        /// /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public virtual void TrySetSide(int index, double value)
        {
            try
            {
                CheckSide(index, value);
                Sides[index] = value;
            }
            catch (ArgumentException)
            {
                throw;
            }
        }

        /// <summary>
        /// Вычисляет сумму элементов массива без учета последних offset элементов
        /// </summary>
        /// <param name="values">Массив элементов</param>
        /// <param name="offset">Количество неучитываемых элементов в конце массива</param>
        /// <returns>Сумма заданных элементов массива</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        protected static double Sum(IList<double> values, int offset)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values), "Ссылка на аргумент имеет значение NULL!");
            }
            if (offset < 0)
            {
                throw new ArgumentException($"Аргумент {nameof(offset)} не может быть отрицательным числом!");
            }
            double sum = 0;
            for (int i = 0; i < values.Count - offset; i++)
            {
                sum += values[i];
            }
            return sum;
        }

        /// <summary>
        /// Проверка возможности создания многоугольника по заданным сторонам
        /// </summary>
        /// <param name="values">Массив размеров сторон многоугольника</param>
        /// <exception cref="ArgumentException"></exception>
        protected virtual void CheckSides(params double[] sides)
        {
            foreach (double side in sides)
            {
                if (side <= 0)
                    throw new ArgumentException("Сторона многоугольника должна быть положительным числом!", nameof(side));
            }

            double[] values = sides.ToArray();
            Array.Sort(values);
            if (Sum(values, 1) < values[^1])
            {
                throw new ArgumentException("Одна из сторон больше суммы остальных сторон!");
            }
        }

        /// <summary>
        /// Проверка возможности изменения размера стороны многоугольника
        /// </summary>
        /// <param name="index">Номер стороны</param>
        /// <param name="value">Новый размер стороны</param>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        protected virtual void CheckSide(int index, double value)
        {
            if (index < 0 || index >= Sides.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }
            if (value <= 0)
            {
                throw new ArgumentException($"Сторона многоугольника должна быть положительным числом!", nameof(value));
            }

            double[] sides = Sides.ToArray();
            sides[index] = value;
            Array.Sort(sides);
            if (Sum(sides, 1) < sides[^1])
            {
                throw new ArgumentException($"Невозможно придать {index}-й стороне размер {value}!");
            }
        }
    }
}
