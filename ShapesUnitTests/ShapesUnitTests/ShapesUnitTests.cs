using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;

namespace ShapesUnitTests
{
    [TestClass]
    public class CircleUnitTests
    {
        [TestMethod]
        public void CircleAreaTest0()
        {
            // Arrange
            double Radius = 54.28;
            double ExpectedArea = 9256.132240576433;
            Shape Circle = new Circle(Radius);

            // Act
            Circle.calculate_area();

            // Assert
            double actual = Circle.Area;
            Assert.AreEqual(ExpectedArea, actual, 0.0001, "Circle area calcualted incorrectly");
        }
        [TestMethod]
        public void CircleAreaTest1()
        {
            // Arrange
            double Radius = 0;
            double ExpectedArea = 0;
            Shape Circle = new Circle(Radius);

            // Act
            Circle.calculate_area();

            // Assert
            double actual = Circle.Area;
            Assert.AreEqual(ExpectedArea, actual, 0.0001, "Circle area calcualted incorrectly");
        }
        [TestMethod]
        public void CircleAreaTest2()
        {
            // Arrange
            double Radius = -1;
            double ExpectedArea = 0;
            Shape Circle = new Circle(Radius);

            // Act
            Circle.calculate_area();

            // Assert
            double actual = Circle.Area;
            Assert.AreEqual(ExpectedArea, actual, 0.0001, "Circle area calcualted incorrectly");
        }
        [TestMethod]
        public void CircleAreaTest3()
        {
            // Arrange
            double ExpectedArea = 0;
            Shape Circle = new Circle();

            // Act
            Circle.calculate_area();

            // Assert
            double actual = Circle.Area;
            Assert.AreEqual(ExpectedArea, actual, 0.0001, "Circle area calcualted incorrectly");
        }
    }
    [TestClass]
    public class TriangleUnitTests
    {
        [TestMethod]
        public void TriangleAreaTest0()
        {
            // Arrange
            double a = 3;
            double b = 4;
            double c = 5;
            double ExpectedArea = 6;
            Shape Triangle = new Triangle(a, b, c);

            // Act
            Triangle.calculate_area();

            // Assert
            double actual = Triangle.Area;
            Assert.AreEqual(ExpectedArea, actual, 0.0001, "Triangle area calcualted incorrectly");
        }
        [TestMethod]
        public void TriangleAreaTest1()
        {
            // Arrange
            double a = -1;
            double b = 4;
            double c = 5;
            double ExpectedArea = 0.4330127018922193;
            Shape Triangle = new Triangle(a, b, c);

            // Act
            Triangle.calculate_area();

            // Assert
            double actual = Triangle.Area;
            Assert.AreEqual(ExpectedArea, actual, 0.0001, "Triangle area calcualted incorrectly");
        }
        [TestMethod]
        public void TriangleAreaTest2()
        {
            // Arrange
            double ExpectedArea = 0.4330127018922193;
            Shape Triangle = new Triangle();

            // Act
            Triangle.calculate_area();

            // Assert
            double actual = Triangle.Area;
            Assert.AreEqual(ExpectedArea, actual, 0.0001, "Triangle area calcualted incorrectly");
        }
        [TestMethod]
        public void TriangleTypeTest0()
        {
            // Arrange
            double a = 3;
            double b = 4;
            double c = 5;
            string ExpectedType = "rectangular";
            Triangle Triangle = new Triangle(a,b,c);

            // Assert
            string actual = Triangle.IsRectangular();
            Assert.AreEqual(ExpectedType, actual, "Triangle type calcualted incorrectly");
        }
        [TestMethod]
        public void TriangleTypeTest1()
        {
            // Arrange
            double a = 2;
            double b = 4;
            double c = 5;
            string ExpectedType = "not rectangular";
            Triangle Triangle = new Triangle(a,b,c);

            // Assert
            string actual = Triangle.IsRectangular();
            Assert.AreEqual(ExpectedType, actual, "Triangle type calcualted incorrectly");
        }
    }
}