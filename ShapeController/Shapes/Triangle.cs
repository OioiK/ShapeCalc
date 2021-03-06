using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeController.Shapes
{
    public abstract class Triangle : ITriangle
    {
        /// <summary>
        /// Катет 1
        /// </summary>
        public double CathetFirst { get; set; }

        /// <summary>
        /// Катет 2
        /// </summary>
        public double CathetSecond { get; set; }

        /// <summary>
        /// Гипотенуза
        /// </summary>
        public double Hypotenuse { get; set; }

        public Triangle(double cathetFirst, double cathetSecond, double hypotenuse)
        {
            this.CathetFirst = cathetFirst;
            this.CathetSecond = cathetSecond;
            this.Hypotenuse = hypotenuse;
        }

        public double GetSquare()
        {
            var perimeter = this.CathetFirst + this.CathetSecond + this.Hypotenuse;

            var formulaResult = (perimeter *
                           (perimeter - this.CathetFirst) *
                           (perimeter - this.CathetSecond) *
                           (perimeter - this.Hypotenuse));

            return Math.Sqrt(formulaResult);
        }

        /// <summary>
        /// Проверить фигуру на возможность расчета
        /// </summary>
        /// <returns>Возможность расчета</returns>
        public bool IsValid()
        {
            return CathetFirst > 0
                   && CathetSecond > 0
                   && Hypotenuse > 0;
        }
    }
}
