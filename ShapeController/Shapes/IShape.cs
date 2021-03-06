using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeController.Shapes
{
    public interface IShape
    {
        // <summary>
        /// Проверить фигуру на возможность расчета
        /// </summary>
        /// <returns>Возможность расчета</returns>
        bool IsValid();

        // <summary>
        /// Рассчитать площадь
        /// </summary>
        /// <returns>Площадь</returns>
        double GetSquare();
    }
}
