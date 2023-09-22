using Calculator.Core.Interface;

namespace Calculator.Core.ActorModel
{
    public class CalculateMessage
    {
        public decimal Num1 { get; }
        public decimal Num2 { get; }
        public IOperation Operation { get; }

        public CalculateMessage(decimal num1, decimal num2, IOperation operation)
        {
            Num1 = num1;
            Num2 = num2;
            Operation = operation;
        }
    }
}
