﻿namespace Visitor
{
    internal class ConcreteElementB : Element
    {
        public override void Accept(Visitor visitor) => visitor.VisitConcreteElementB(this);
        public void OperationB() { }
    }
}
