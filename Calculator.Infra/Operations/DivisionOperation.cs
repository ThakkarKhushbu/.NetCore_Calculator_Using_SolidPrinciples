using Calculator.Core.Interface;

namespace Calculator.Core.Operations
{
    public class DivisionOperation : IOperation
    {
        public decimal Calculate(decimal a, decimal b)
        {
            try
            {
                return a / b;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Division by zero error: {ex.Message}");
                return 0;
            }
        }
    }
}
