using System;

namespace Visitor
{
    internal class Program
    {
        private static void Main()
        {
            var objectStructure = new ObjectStructure();
            objectStructure.Attach(new ConcreteElementA());
            objectStructure.Attach(new ConcreteElementB());

            var visitor1 = new ConcreteVisitor1();
            var visitor2 = new ConcreteVisitor2();

            objectStructure.Accept(visitor1);
            objectStructure.Accept(visitor2);

            Console.ReadKey();
        }
    }
}
