using Calculator.Core.Interface;
using Calculator.Core.Operations;
using Xunit;

namespace Calculator.Tests.Tests
{

    public class MultiplicationOperationTests
    {
        private readonly IOperation _multiplicationOperation;

        public MultiplicationOperationTests()
        {
            _multiplicationOperation = new MultiplicationOperation();
        }

        [Fact]
        public void Calculate_Multiplication_Success()
        {
            // Arrange
            decimal num1 = 5;
            decimal num2 = 3;

            // Act
            decimal result = _multiplicationOperation.Calculate(num1, num2);

            // Assert
            Assert.Equal(15, result);
        }

        [Fact]
        public void Calculate_Multiplication_NegativeNumbers_Success()
        {
            // Arrange
            decimal num1 = -7;
            decimal num2 = 4;

            // Act
            decimal result = _multiplicationOperation.Calculate(num1, num2);

            // Assert
            Assert.Equal(-28, result);
        }

        [Fact]
        public void Calculate_Multiplication_DecimalNumbers_Success()
        {
            // Arrange
            decimal num1 = 2.5m;
            decimal num2 = 3;

            // Act
            decimal result = _multiplicationOperation.Calculate(num1, num2);

            // Assert
            Assert.Equal(7.5m, result);
        }
    }
}
