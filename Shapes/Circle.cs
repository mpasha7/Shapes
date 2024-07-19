using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    /// <summary>
    /// Круг
    /// </summary>
    public class Circle : IShape
    {
        /// <summary>
        /// Радиус круга
        /// </summary>
        public double Radius { get; private set; }

        /// <summary>
        /// Инициирует объект класса Circle по его радиусу
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        /// <exception cref="ArgumentException"></exception>
        public Circle(double radius)
        {
            try
            {
                SetRadius(radius);
            }
            catch (ArgumentException)
            {
                throw;
            }
        }

        /// <summary>
        /// Устанавливает радиус круга
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        /// <exception cref="ArgumentException"></exception>
        public virtual void SetRadius(double radius)
        {
            if (radius > 0)
            {
                this.Radius = radius;
            }
            else
            {
                throw new ArgumentException("Радиус круга не может быть отрицательным числом!");
            }
        }

        /// <summary>
        /// Вычисляет площадь круга
        /// </summary>
        /// <returns>Площадь круга</returns>
        public virtual double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        /// <summary>
        /// Вычисляет длину окружности круга
        /// </summary>
        /// <returns>Длина окружности круга</returns>
        public virtual double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
