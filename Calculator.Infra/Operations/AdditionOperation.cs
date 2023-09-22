using Calculator.Core.Interface;

namespace Calculator.Core.Operations
{
    public class AdditionOperation : IOperation
    {
        public decimal Calculate(decimal a, decimal b)
        {
            return a + b;
        }
    }
}
