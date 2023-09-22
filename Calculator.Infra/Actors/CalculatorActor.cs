using Akka.Actor;
using Calculator.Core.ActorModel;

namespace Calculator.Core.Actors
{
    public class CalculatorActor : ReceiveActor
    {
        public CalculatorActor()
        {
            Receive<CalculateMessage>(message =>
            {
                decimal result = message.Operation.Calculate(message.Num1, message.Num2);
                Sender.Tell(new ResultMessage(result));
            });
        }
    }
}
