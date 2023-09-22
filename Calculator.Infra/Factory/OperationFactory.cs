using Calculator.Core.Interface;
using Calculator.Core.Operations;

namespace Calculator.Core.Factory
{
    public static class OperationFactory
    {
        private static readonly Dictionary<string, Func<IOperation>> OperationCreators = new()
        {
            { "+", () => new AdditionOperation() },
            { "-", () => new SubtractionOperation() },
            { "*", () => new MultiplicationOperation() },
            { "/", () => new DivisionOperation() }
        };

        public static IOperation CreateOperation(string operationSymbol)
        {
            return OperationCreators.TryGetValue(operationSymbol, out Func<IOperation>? creator)
                ? creator()
                : throw new InvalidOperationException($"Invalid operation symbol: {operationSymbol}");
        }

        public static bool IsValidOperationSymbol(string operationSymbol)
        {
            return operationSymbol is "+" or "-" or "*" or "/";
        }
    }
}
