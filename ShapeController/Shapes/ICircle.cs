using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeController.Shapes
{
    public interface ICircle : IShape
    {
        /// <summary>
        /// Радиус
        /// </summary>
        double Radius { get; set; }
    }
}
