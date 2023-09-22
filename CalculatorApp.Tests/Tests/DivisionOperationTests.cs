using Calculator.Core.Interface;
using Calculator.Core.Operations;
using Xunit;

namespace Calculator.Tests.Tests
{
    public class DivisionOperationTests
    {
        private readonly IOperation _divisionOperation;

        public DivisionOperationTests()
        {
            _divisionOperation = new DivisionOperation();
        }

        [Fact]
        public void Calculate_Division_Success()
        {
            // Arrange
            decimal num1 = 10;
            decimal num2 = 2;

            // Act
            decimal result = _divisionOperation.Calculate(num1, num2);

            // Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void Calculate_Division_DecimalNumbers_Success()
        {
            // Arrange
            decimal num1 = 7;
            decimal num2 = 3;

            // Act
            decimal result = _divisionOperation.Calculate(num1, num2);

            // Assert
            Assert.Equal(7 / 3m, result);
        }

        [Fact]
        public void Calculate_Division_ZeroDivisor_ExceptionThrown()
        {
            // Arrange
            decimal num1 = 10;
            decimal num2 = 0;

            // Act
            decimal result = _divisionOperation.Calculate(num1, num2);

            // Assert
            Assert.Equal(0, result);
        }
    }
}
