using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator.Interfaces
{
    public interface IShape
    {
        /// <summary>
        /// Метод считающий площадь фигуры.
        /// </summary>
        /// <returns>Площадь фигуры.</returns>
        public double GetArea();
    }
}
