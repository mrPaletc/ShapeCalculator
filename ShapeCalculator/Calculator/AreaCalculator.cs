using ShapeCalculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator.Calculator
{
    public class AreaCalculator : ICalculator
    {
        private IShape shape;
        /// <summary>
        /// Конструктор класс <see cref="ICalculator"/>
        /// </summary>
        /// <param name="shape">
        /// Фигура для которой вызывается калькулятор.
        /// </param>
        public AreaCalculator(IShape shape)
        {
            this.shape = shape;
        }
        public double GetArea()
        {
            return shape.GetArea();
        }
    }
}
