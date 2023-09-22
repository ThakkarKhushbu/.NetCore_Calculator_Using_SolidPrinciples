using Akka.Actor;
using Calculator.Core.Actors;
using Calculator.Infra.UI;

namespace Calculator.App
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using ActorSystem system = ActorSystem.Create("CalculatorSystem");
            IActorRef calculatorActor = system.ActorOf<CalculatorActor>("CalculatorActor");

            CalculatorUI calculatorUI = new(calculatorActor);
            calculatorUI.Run();
            Environment.Exit(0);
        }
    }
}