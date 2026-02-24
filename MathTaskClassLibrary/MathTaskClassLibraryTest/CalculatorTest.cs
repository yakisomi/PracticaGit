using MathTaskClassLibrary;

namespace MathTaskClassLibraryTest
{
    [TestClass]
    public sealed class CalculatorTest
    {
        [TestMethod]
        public void Add_TwoPositiveNumbers_ReturnsCorrectSum()
        {
            // Arrange
            var calculator = new Calculator();
            double number1 = 5.5;
            double number2 = 3.2;
            double expectedResult = 8.7;
            // Act
            double actualResult = calculator.Add(number1, number2);
            // Assert
            Assert.AreEqual(expectedResult, actualResult, 0.001);
        }

        [TestMethod]
        public void Add_TwoNegativeNumbers_ReturnsCorrectSum()
        {
            // Arrange
            var calculator = new Calculator();
            double number1 = -10;
            double number2 = -5;
            double expectedResult = -15;
            // Act
            double actualResult = calculator.Add(number1, number2);
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Add_PositiveAndNegativeNumber_ReturnsCorrectSum()
        {
            // Arrange
            var calculator = new Calculator();
            double number1 = 10;
            double number2 = -3;
            double expectedResult = 7;
            // Act
            double actualResult = calculator.Add(number1, number2);
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Subtract_FirstGreaterThanSecond_ReturnsPositive()
        {
            // Arrange
            var calculator = new Calculator();
            double number1 = 15;
            double number2 = 5;
            double expectedResult = 10;
            // Act
            double actualResult = calculator.Subtract(number1, number2);
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Subtract_FirstLessThanSecond_ReturnsNegative()
        {
            // Arrange
            var calculator = new Calculator();
            double number1 = 5;
            double number2 = 15;
            double expectedResult = -10;
            // Act
            double actualResult = calculator.Subtract(number1, number2);
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Subtract_EqualNumbers_ReturnsZero()
        {
            // Arrange
            var calculator = new Calculator();
            double number1 = 10;
            double number2 = 10;
            double expectedResult = 0;
            // Act
            double actualResult = calculator.Subtract(number1, number2);
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Multiply_TwoPositiveNumbers_ReturnsPositive()
        {
            // Arrange
            var calculator = new Calculator();
            double number1 = 4;
            double number2 = 3;
            double expectedResult = 12;
            // Act
            double actualResult = calculator.Multiply(number1, number2);
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Multiply_PositiveAndNegative_ReturnsNegative()
        {
            // Arrange
            var calculator = new Calculator();
            double number1 = 4;
            double number2 = -3;
            double expectedResult = -12;
            // Act
            double actualResult = calculator.Multiply(number1, number2);
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Multiply_ByZero_ReturnsZero()
        {
            // Arrange
            var calculator = new Calculator();
            double number1 = 5;
            double number2 = 0;
            double expectedResult = 0;
            // Act
            double actualResult = calculator.Multiply(number1, number2);
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Multiply_TwoNegativeNumbers_ReturnsPositive()
        {
            // Arrange
            var calculator = new Calculator();
            double number1 = -4;
            double number2 = -3;
            double expectedResult = 12;
            // Act
            double actualResult = calculator.Multiply(number1, number2);
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Divide_TwoPositiveNumbers_ReturnsCorrectQuotient()
        {
            // Arrange
            var calculator = new Calculator();
            double number1 = 10;
            double number2 = 2;
            double expectedResult = 5;
            // Act
            double actualResult = calculator.Divide(number1, number2);
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Divide_WithDecimalResult_ReturnsCorrectValue()
        {
            // Arrange
            var calculator = new Calculator();
            double number1 = 5;
            double number2 = 2;
            double expectedResult = 2.5;
            // Act
            double actualResult = calculator.Divide(number1, number2);
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Divide_NegativeByPositive_ReturnsNegative()
        {
            // Arrange
            var calculator = new Calculator();
            double number1 = -10;
            double number2 = 2;
            double expectedResult = -5;
            // Act
            double actualResult = calculator.Divide(number1, number2);
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Divide_ByZero_ThrowsDivideByZeroException()
        {
            // Arrange
            var calculator = new Calculator();
            double number1 = 10;
            double number2 = 0;
            // Act
            calculator.Divide(number1, number2);
            // Assert - ожидается исключение через атрибут
        }
        [TestMethod]
        public void Divide_ZeroByNumber_ReturnsZero()
        {
            // Arrange
            var calculator = new Calculator();
            double number1 = 0;
            double number2 = 5;
            double expectedResult = 0;
            // Act
            double actualResult = calculator.Divide(number1, number2);
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(2, 3, 5)]
        [DataRow(0, 0, 0)]
        [DataRow(-5, 5, 0)]
        public void Add_MultipleCases_ReturnsCorrectSum(int a, int b, int
expected)
        {
            var calc = new Calculator();
            var result = calc.Add(a, b);
            Assert.AreEqual(expected, result);
        }
        [DataTestMethod]
        [DataRow(6, 2, 3)]
        [DataRow(10, 5, 2)]
        [DataRow(0, 5, 0)]
        public void Divide_MultipleCases_ReturnsCorrectQuotient(double a,
        double b, double expected)
        {
            var calc = new Calculator();
            var result = calc.Divide(a, b);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        //-----------------------------------------------------------------
        public void Power_PositiveBaseAndExponent_ReturnsCorrectValue()
        {
            var calculator = new Calculator();
            double result = calculator.Power(2, 3);
            Assert.AreEqual(8, result, 0.001);
        }

        [TestMethod]
        public void Power_NegativeBaseAndEvenExponent_ReturnsPositive()
        {
            var calculator = new Calculator();
            double result = calculator.Power(-2, 4);
            Assert.AreEqual(16, result, 0.001);
        }

        [TestMethod]
        public void Power_NegativeBaseAndOddExponent_ReturnsNegative()
        {
            var calculator = new Calculator();
            double result = calculator.Power(-2, 3);
            Assert.AreEqual(-8, result, 0.001);
        }

        [TestMethod]
        public void Power_ZeroExponent_ReturnsOne()
        {
            var calculator = new Calculator();
            double result = calculator.Power(5, 0);
            Assert.AreEqual(1, result, 0.001);
        }

        [TestMethod]
        public void Power_FractionalExponent_ReturnsCorrectValue()
        {
            var calculator = new Calculator();
            double result = calculator.Power(4, 0.5);
            Assert.AreEqual(2, result, 0.001);
        }

        [TestMethod]
        public void Power_BaseZero_ReturnsZero()
        {
            var calculator = new Calculator();
            double result = calculator.Power(0, 3);
            Assert.AreEqual(0, result, 0.001);
        }

        [TestMethod]
        public void SquareRoot_PositiveNumber_ReturnsCorrectValue()
        {
            var calculator = new Calculator();
            double result = calculator.SquareRoot(9);
            Assert.AreEqual(3, result, 0.001);
        }

        [TestMethod]
        public void SquareRoot_Zero_ReturnsZero()
        {
            var calculator = new Calculator();
            double result = calculator.SquareRoot(0);
            Assert.AreEqual(0, result, 0.001);
        }

        [TestMethod]
        public void SquareRoot_DecimalNumber_ReturnsCorrectValue()
        {
            var calculator = new Calculator();
            double result = calculator.SquareRoot(2.25);
            Assert.AreEqual(1.5, result, 0.001);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SquareRoot_NegativeNumber_ThrowsArgumentException()
        {
            var calculator = new Calculator();
            calculator.SquareRoot(-4);
        }

        [TestMethod]
        public void Percentage_PositiveValues_ReturnsCorrectPercentage()
        {
            var calculator = new Calculator();
            double result = calculator.Percentage(200, 25);
            Assert.AreEqual(50, result, 0.001);
        }

        [TestMethod]
        public void Percentage_ZeroValue_ReturnsZero()
        {
            var calculator = new Calculator();
            double result = calculator.Percentage(0, 50);
            Assert.AreEqual(0, result, 0.001);
        }

        [TestMethod]
        public void Percentage_ZeroPercent_ReturnsZero()
        {
            var calculator = new Calculator();
            double result = calculator.Percentage(100, 0);
            Assert.AreEqual(0, result, 0.001);
        }

        [TestMethod]
        public void Percentage_NegativeValue_PositivePercent_ReturnsNegative()
        {
            var calculator = new Calculator();
            double result = calculator.Percentage(-200, 25);
            Assert.AreEqual(-50, result, 0.001);
        }

        [TestMethod]
        public void Percentage_PositiveValue_NegativePercent_ReturnsNegative()
        {
            var calculator = new Calculator();
            double result = calculator.Percentage(200, -25);
            Assert.AreEqual(-50, result, 0.001);
        }

        [DataTestMethod]
        [DataRow(100, 50, 50)]
        [DataRow(200, 25, 50)]
        [DataRow(0, 100, 0)]
        [DataRow(300, 33.33, 99.99)]
        [DataRow(-100, 50, -50)]
        public void Percentage_WithDataRows_ReturnsCorrectValue(double value, double percent, double expected)
        {
            var calculator = new Calculator();
            double result = calculator.Percentage(value, percent);
            Assert.AreEqual(expected, result, 0.01);
        }

        [DataTestMethod]
        [DataRow(2, 3, 8)]
        [DataRow(3, 2, 9)]
        [DataRow(5, 0, 1)]
        [DataRow(2, -1, 0.5)]
        [DataRow(4, 0.5, 2)]
        public void Power_WithDataRows_ReturnsCorrectValue(double @base, double exponent, double expected)
        {
            var calculator = new Calculator();
            double result = calculator.Power(@base, exponent);
            Assert.AreEqual(expected, result, 0.001);
        }

        [TestMethod]
        public void ClearMemory_SetsMemoryValueToZero()
        {
            var calculator = new Calculator();
            calculator.MemoryAdd(100);
            calculator.ClearMemory();
            Assert.AreEqual(0, calculator.MemoryValue);
        }

        [TestMethod]
        public void MemoryAdd_MultipleOperations()
        {
            var calculator = new Calculator();
            calculator.MemoryAdd(10);
            calculator.MemoryAdd(20);
            calculator.MemoryAdd(30);
            Assert.AreEqual(60, calculator.MemoryValue);
        }

        [TestMethod]
        public void MemorySubtract_MultipleOperations_Subtract()
        {
            var calculator = new Calculator();
            calculator.MemoryAdd(100);
            calculator.MemorySubtract(30);
            calculator.MemorySubtract(20);
            Assert.AreEqual(50, calculator.MemoryValue);
        }

        [TestMethod]
        public void MemoryOperations_AfterClear_WorkCorrectly()
        {
            var calculator = new Calculator();
            calculator.MemoryAdd(100);
            calculator.ClearMemory();
            calculator.MemoryAdd(25);
            calculator.MemorySubtract(10);
            Assert.AreEqual(15, calculator.MemoryValue);
        }
    }
}
 