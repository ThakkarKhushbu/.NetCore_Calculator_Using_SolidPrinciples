using Calculator.Core.Interface;
using Calculator.Core.Operations;
using Xunit;

namespace Calculator.Tests.Tests
{
    public class SubtractionOperationTests
    {
        private readonly IOperation _subtractionOperation;

        public SubtractionOperationTests()
        {
            _subtractionOperation = new SubtractionOperation();
        }

        [Fact]
        public void Calculate_Subtraction_Success()
        {
            // Arrange
            decimal num1 = 10;
            decimal num2 = 4;

            // Act
            decimal result = _subtractionOperation.Calculate(num1, num2);

            // Assert
            Assert.Equal(6, result);
        }

        [Fact]
        public void Calculate_Subtraction_NegativeNumbers_Success()
        {
            // Arrange
            decimal num1 = 7;
            decimal num2 = -3;

            // Act
            decimal result = _subtractionOperation.Calculate(num1, num2);

            // Assert
            Assert.Equal(10, result);
        }

        [Fact]
        public void Calculate_Subtraction_DecimalNumbers_Success()
        {
            // Arrange
            decimal num1 = 8.5m;
            decimal num2 = 2.3m;

            // Act
            decimal result = _subtractionOperation.Calculate(num1, num2);

            // Assert
            Assert.Equal(6.2m, result);
        }
    }
}
