using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeCalculator.Shapes;
using System;

namespace ShapeCalculatorTests
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void TestPositiveRadius()
        {
            // Arrange
            double radius = 1;

            // Assert
            try
            {
                Circle circle = new Circle(radius);
            }
            catch (Exception ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }
        }

        [TestMethod]
        public void TestZeroRadius()
        {
            // Arrange
            double radius = 0;

            // Assert
            Assert.ThrowsException<ArgumentException>(() => new Circle(radius));
        }

        [TestMethod]
        public void TestNegativeRadius()
        {
            // Arrange
            double radius = -1;

            // Assert
            Assert.ThrowsException<ArgumentException>(() => new Circle(radius));
        }
    }
}