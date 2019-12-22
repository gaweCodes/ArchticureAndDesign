using System;

namespace Mediator
{
    internal class Program
    {
        private static void Main()
        {
            var component1 = new Component1();
            var component2 = new Component2();
            var concreteMediator = new ConcreteMediator(component1, component2);
            Console.WriteLine("Client triggers operation A.");
            component1.DoA();
            Console.WriteLine();
            Console.WriteLine("Client triggers operation D.");
            component2.DoD();

            concreteMediator.Notify(55, "A");
        }
    }
}
