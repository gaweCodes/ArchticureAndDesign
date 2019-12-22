namespace Prototype
{
    internal class ConcretePrototype2 : Prototype
    {
        public ConcretePrototype2(string id) : base(id) { }
        public override Prototype Clone() => (Prototype) MemberwiseClone();
    }
}
