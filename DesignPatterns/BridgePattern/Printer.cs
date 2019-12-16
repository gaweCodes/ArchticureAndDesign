namespace BridgePattern
{
    public class Printer : AbstractPrinter
    {
        public Printer(IPrinting printingImplementation) : base(printingImplementation) { }
        public override void Print() => PrintImplementation.Print("A");
    }
}
