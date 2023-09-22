using Calculator.Core.Factory;
using Calculator.Core.Interface;
using Calculator.Core.Operations;
using Xunit;

namespace Calculator.Tests.Tests
{
    public class OperationFactoryTests
    {
        [Fact]
        public void CreateOperation_Addition_Success()
        {
            // Arrange
            string operationSymbol = "+";

            // Act
            IOperation operation = OperationFactory.CreateOperation(operationSymbol);

            // Assert
            _ = Assert.IsType<AdditionOperation>(operation);
        }

        [Fact]
        public void CreateOperation_Subtraction_Success()
        {
            // Arrange
            string operationSymbol = "-";

            // Act
            IOperation operation = OperationFactory.CreateOperation(operationSymbol);

            // Assert
            _ = Assert.IsType<SubtractionOperation>(operation);
        }

        [Fact]
        public void CreateOperation_Multiplication_Success()
        {
            // Arrange
            string operationSymbol = "*";

            // Act
            IOperation operation = OperationFactory.CreateOperation(operationSymbol);

            // Assert
            _ = Assert.IsType<MultiplicationOperation>(operation);
        }

        [Fact]
        public void CreateOperation_Division_Success()
        {
            // Arrange
            string operationSymbol = "/";

            // Act
            IOperation operation = OperationFactory.CreateOperation(operationSymbol);

            // Assert
            _ = Assert.IsType<DivisionOperation>(operation);
        }

        [Fact]
        public void CreateOperation_InvalidSymbol_ExceptionThrown()
        {
            // Arrange
            string operationSymbol = "$";

            // Act and Assert
            _ = Assert.Throws<InvalidOperationException>(() => OperationFactory.CreateOperation(operationSymbol));
        }

        [Fact]
        public void IsValidOperationSymbol_ValidSymbol_ReturnsTrue()
        {
            // Arrange
            string operationSymbol = "+";

            // Act
            bool isValid = OperationFactory.IsValidOperationSymbol(operationSymbol);

            // Assert
            Assert.True(isValid);
        }

        [Fact]
        public void IsValidOperationSymbol_InvalidSymbol_ReturnsFalse()
        {
            // Arrange
            string operationSymbol = "&";

            // Act
            bool isValid = OperationFactory.IsValidOperationSymbol(operationSymbol);

            // Assert
            Assert.False(isValid);
        }
    }
}
