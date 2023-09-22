using Calculator.Core.Interface;
using Calculator.Core.Operations;
using Xunit;

namespace Calculator.Tests.Tests
{
    public class AdditionOperationTests
    {
        private readonly IOperation _additionOperation;

        public AdditionOperationTests()
        {
            _additionOperation = new AdditionOperation();
        }

        [Fact]
        public void Calculate_Addition_Success()
        {
            // Arrange
            decimal num1 = 5;
            decimal num2 = 3;

            // Act
            decimal result = _additionOperation.Calculate(num1, num2);

            // Assert
            Assert.Equal(8, result);
        }

        [Fact]
        public void Calculate_Addition_NegativeNumbers_Success()
        {
            // Arrange
            decimal num1 = -10;
            decimal num2 = 7;

            // Act
            decimal result = _additionOperation.Calculate(num1, num2);

            // Assert
            Assert.Equal(-3, result);
        }
    }
}
