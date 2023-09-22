using Akka.Actor;
using Calculator.Core.ActorModel;
using Calculator.Core.Factory;
using Calculator.Core.Interface;

namespace Calculator.Infra.UI
{
    public class CalculatorUI
    {
        private readonly IActorRef _calculatorActor;

        public CalculatorUI(IActorRef calculatorActor)
        {
            _calculatorActor = calculatorActor;
        }

        public void Run()
        {
            Console.WriteLine("Welcome to the Calculator App!");

            while (true)
            {
                decimal num1, num2;
                string operationSymbol;

                while (true)
                {
                    Console.Write("Enter the first number: ");
                    if (decimal.TryParse(Console.ReadLine(), out num1))
                    {
                        break;
                    }

                    Console.WriteLine("Invalid input. Please enter a valid decimal number.");
                }

                while (true)
                {
                    Console.Write("Enter the operation (+, -, *, /): ");
                    operationSymbol = Console.ReadLine();
                    if (OperationFactory.IsValidOperationSymbol(operationSymbol))
                    {
                        break;
                    }

                    Console.WriteLine("Invalid operation. Please enter a valid operation symbol.");
                }

                while (true)
                {
                    Console.Write("Enter the second number: ");
                    if (decimal.TryParse(Console.ReadLine(), out num2))
                    {
                        break;
                    }

                    Console.WriteLine("Invalid input. Please enter a valid decimal number.");
                }

                try
                {
                    IOperation operation = OperationFactory.CreateOperation(operationSymbol);

                    CalculateMessage calculateMessage = new(num1, num2, operation);
                    Task<ResultMessage> resultTask = _calculatorActor.Ask<ResultMessage>(calculateMessage);

                    resultTask.Wait();
                    ResultMessage resultMessage = resultTask.Result;
                    decimal result = resultMessage.Result;

                    Console.WriteLine($"Result: {result}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

                Console.Write("Do you want to perform another calculation? (y/n): ");
                string continueCalculation = Console.ReadLine();
                if (continueCalculation.ToLower() != "y")
                {
                    Console.WriteLine("Exiting the application.");
                    break;
                }
            }
        }
    }
}