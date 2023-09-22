using Akka.Actor;
using Calculator.Core.Actors;
using Calculator.Infra.UI;
using Xunit;

namespace Calculator.Tests.Tests
{
    public class CalculatorUITests
    {

        [Theory]
        [InlineData("5", "+", "3")]
        [InlineData("10", "-", "2")]
        [InlineData("2", "*", "7")]
        [InlineData("12", "/", "3")]
        public void Run_Should_CalculateResults(string num1, string operationSymbol, string num2)
        {
            // Arrange
            using ActorSystem system = ActorSystem.Create("TestCalculatorSystem");
            IActorRef calculatorActor = system.ActorOf<CalculatorActor>("TestCalculatorActor");
            CalculatorUI calculatorUI = new(calculatorActor);

            // Act
            using StringWriter sw = new();
            Console.SetOut(sw);

            using StringReader sr = new($"{num1}{Environment.NewLine}{operationSymbol}{Environment.NewLine}{num2}{Environment.NewLine}n");
            Console.SetIn(sr);

            calculatorUI.Run();

            // Assert
            string output = sw.ToString();
            Assert.Contains("Result:", output);
        }
    }
}
