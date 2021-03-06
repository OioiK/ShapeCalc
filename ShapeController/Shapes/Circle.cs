using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeController.Shapes
{
    public abstract class Circle : ICircle
    {
        /// <summary>
        /// Радиус
        /// </summary>
        public double Radius { get; set; }
        public Circle(double radius)
        {
            this.Radius = radius;
        }
        public double GetSquare()
        {
            return Math.PI * this.Radius * this.Radius;
        }

        /// <summary>
        /// Проверить фигуру на возможность расчета
        /// </summary>
        /// <returns>Возможность расчета</returns>
        bool IShape.IsValid()
        {
            return Radius > 0;
        }
    }
}
