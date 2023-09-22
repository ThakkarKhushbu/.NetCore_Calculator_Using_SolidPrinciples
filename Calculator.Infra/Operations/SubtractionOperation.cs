using Calculator.Core.Interface;

namespace Calculator.Core.Operations
{
    public class SubtractionOperation : IOperation
    {
        public decimal Calculate(decimal a, decimal b)
        {
            return a - b;
        }
    }
}
