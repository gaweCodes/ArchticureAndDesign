using System;

namespace Prototype
{
    internal class Program
    {
        private static void Main()
        {
            ConcretePrototype1 p1 = new ConcretePrototype1("This is Concrete 1");
            ConcretePrototype1 c1 = (ConcretePrototype1)p1.Clone();
            Console.WriteLine("Cloned: {0}", c1.Id);
            ConcretePrototype2 p2 = new ConcretePrototype2("This is Concrete 2");
            ConcretePrototype2 c2 = (ConcretePrototype2)p2.Clone();
            Console.WriteLine("Cloned: {0}", c2.Id);
            Console.ReadLine();
        }
    }
}
