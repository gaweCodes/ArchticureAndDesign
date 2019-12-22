namespace Prototype
{
    internal class ConcretePrototype1 : Prototype
    {
        public ConcretePrototype1(string id) : base(id) { }
        public override Prototype Clone() => (Prototype) MemberwiseClone();
    }
}
