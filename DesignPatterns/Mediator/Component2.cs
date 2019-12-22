using System;

namespace Mediator
{
    internal class Component2 : BaseComponent
    {
        public void DoC()
        {
            Console.WriteLine("Component 2 does C.");
            Mediator.Notify(this, "C");
        }
        public void DoD()
        {
            Console.WriteLine("Component 2 does D.");
            Mediator.Notify(this, "D");
        }
    }
}
