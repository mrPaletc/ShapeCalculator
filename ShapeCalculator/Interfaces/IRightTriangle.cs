using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator.Interfaces
{
    public interface IRightTriangle
    {
        /// <summary>
        /// Метод проверяющий является ли треугольник прямым.
        /// </summary>
        /// <returns>true если прямоугольный, false если нет.</returns>
        public bool IsRight();
    }
}
