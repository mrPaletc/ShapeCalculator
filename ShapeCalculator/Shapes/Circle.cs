using ShapeCalculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator.Shapes
{
    public class Circle : IShape
    {
        public double Radius { get; init; }

        /// <summary>
        /// Конструктор класс <see cref="Circle"/>
        /// </summary>
        /// <param name="radius">
        /// Радиус круга.
        /// </param>
        public Circle(double radius)
        {
            if(radius <= 0 )
                throw new ArgumentException("Радиус должен быть больше нуля.");
            Radius = radius;
        }
        public double GetArea() => Math.PI * Math.Pow(Radius, 2);
    }
}
