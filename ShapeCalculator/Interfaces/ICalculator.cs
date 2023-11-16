using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator.Interfaces
{
    public interface ICalculator
    {
        /// <summary>
        /// Метод возвращающий площадь фигуры переданной в конструктор калькулятора.
        /// </summary>
        /// <returns>Площадь фигуры.</returns>
        public double GetArea();
    }
}
