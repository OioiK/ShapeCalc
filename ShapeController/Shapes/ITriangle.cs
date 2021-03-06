using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeController.Shapes
{
    interface ITriangle : IShape
    {
        /// <summary>
        /// Первый катет
        /// </summary>
        double CathetFirst { get; set; }

        /// <summary>
        /// Второй катет
        /// </summary>
        double CathetSecond { get; set; }

        /// <summary>
        /// Гипотенуза
        /// </summary>
        double Hypotenuse { get; set; }
    }
}
