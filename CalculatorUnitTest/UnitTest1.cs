using Valentine_Ohalebo_8957771;

namespace CalculatorUnitTest
{
    public class Tests
    {
        Calculator calculator;
        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void TestAddition_WithNegative()
        {
            // Arrange
            double a = -10;
            double b = 20;
            // Act
            double result = calculator.Add(a, b);
            // Assert
            Assert.AreEqual(10, result);
        }

        [Test]
        public void TestAddition_WithZero()
        {
            // Arrange
            double a = 0;
            double b = 40;
            // Act
            double result = calculator.Add(a, b);
            // Assert
            Assert.AreEqual(40, result);
        }

        [Test] 
        public void TestSubtraction_WithNegative()
        {
            // Arrange
            double a = 20;
            double b = -10;
            // Act
            double result = calculator.Subtract(a, b);
            // Assert
            Assert.AreEqual(30, result);
        }

        [Test]
        public void TestSubtraction_WithZero()
        {
            // Arrange
            double a = 5;
            double b = 0;
            // Act
            double result = calculator.Subtract(a, b);
            // Assert
            Assert.AreEqual(5, result);
        }

        [Test]
        public void TestMultiplication_WithNegative()
        {
            // Arrange
            double a = 5;
            double b = -12;
            // Act
            double result = calculator.Multiply(a, b);
            // Assert
            Assert.AreEqual(-60, result);
        }

        [Test]
        public void TestMultiplication_WithZero()
        {
            // Arrange
            double a = 0;
            double b = 45;
            // Act
            double result = calculator.Multiply(a, b);
            // Assert
            Assert.AreEqual(0, result);
        }

        [Test] 
        public void TestDivision_WithNegative()
        {
            // Arrange
            double a = 16;
            double b = -8;
            // Act
            double result = calculator.Divide(a, b);
            // Assert
            Assert.AreEqual(-2, result);
        }

        [Test]
        public void TestDivision_WithZero()
        {
            // Arrange
            double a = -33;
            double b = 11;
            // Act
            double result = calculator.Divide(a, b);
            // Assert
            Assert.AreEqual(-3, result);
        }
    }
}



