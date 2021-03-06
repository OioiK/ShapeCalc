using ShapeController.Shapes;
using System;

namespace ShapeController
{
    public class ShapeProcessor
    {
        /// <summary>
        /// Получить площадь фигуры
        /// </summary>
        /// <param name="shape">Фигура</param>
        /// <returns>Площадь</returns>
        public static double CalculateSquare(IShape shape)
        {
            if (!shape.IsValid())
            {
                throw new ArgumentException();
            }

            return shape.GetSquare();
        }        
    }
}
