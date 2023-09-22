namespace Calculator.Core.ActorModel
{
    public class ResultMessage
    {
        public decimal Result { get; }

        public ResultMessage(decimal result)
        {
            Result = result;
        }
    }
}
