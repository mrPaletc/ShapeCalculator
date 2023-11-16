using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeCalculator;
using ShapeCalculator.Shapes;
using System;

namespace ShapeCalculatorTests
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void TestCorrectConstructor()
        {
            // Arrange
            double sideA = 1;
            double sideB = 1;
            double sideC = 1;

            // Assert
            try
            {
                Triangle triangle = new Triangle(sideA, sideB, sideC);
            }
            catch (Exception ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }
        }

        [TestMethod]
        public void TestInCorrectConstructor()
        {
            // Arrange
            double sideA = 1;
            double sideB = 1;
            double sideC = 6;

            // Assert
            Assert.ThrowsException<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
        }

        [TestMethod]
        public void TestNegativeSidesConstructor()
        {
            // Arrange
            double sideA = -1;
            double sideB = -1;
            double sideC = -1;

            // Assert
            Assert.ThrowsException<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
        }

        [TestMethod]
        public void TestZeroSidesConstructor()
        {
            // Arrange
            double sideA = 0;
            double sideB = 0;
            double sideC = 0;

            // Assert
            Assert.ThrowsException<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
        }

        [TestMethod]
        public void TestIsRight()
        {
            // Arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;

            Triangle triangle = new Triangle(sideA, sideB, sideC);

            // Assert
            Assert.IsTrue(triangle.IsRight(), "Треугольник должен был быть правильным, но вышло иначе");
        }

        [TestMethod]
        public void TestIsNotRight()
        {            
            // Arrange
            double sideA = 6;
            double sideB = 6;
            double sideC = 6;

            Triangle triangle = new Triangle(sideA, sideB, sideC);

            // Assert
            Assert.IsFalse(triangle.IsRight(), "Треугольник не должен был быть правильным, но вышло иначе");
        }
    }
}