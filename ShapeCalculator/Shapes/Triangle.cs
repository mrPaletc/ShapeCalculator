using ShapeCalculator.Interfaces;

namespace ShapeCalculator
{
    public class Triangle : IShape, IRightTriangle
    {
        /// <value>Массив сторон треугольника.</value>
        public double[] sides { get; init; }

        /// <summary>
        /// Конструктор класс <see cref="Triangle"/>
        /// </summary>
        /// <param name="a">
        /// Сторона треугольника.
        /// </param>
        /// /// <param name="b">
        /// Сторона треугольника.
        /// </param>
        /// /// <param name="c">
        /// Сторона треугольника.
        /// </param>
        public Triangle(double a, double b, double c)
        {
            sides = new double[] { a, b, c };
            if (sides.Any(x => x <=0))
                throw new ArgumentException("Стороны должен быть положительным.");
            if (sides[2] >= sides[0] + sides[1])
                throw new ArgumentException("Треугольник с такими сторонами не может существовать.");
            Array.Sort(sides);
        }
        public double GetArea()
        {
            double p = sides.Sum() / 2;
            double Area = Math.Sqrt(p * (p - sides[0]) * (p - sides[1]) * (p - sides[2]));
            return Area;
        }

        public bool IsRight()
        {
            return Math.Pow(sides[2],2) == Math.Pow(sides[1], 2) + Math.Pow(sides[0], 2);
        }
    }
}