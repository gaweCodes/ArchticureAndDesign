namespace BridgePattern
{
    public class Printer : AbstractPrinter
    {
        public Printer(IPrinting printingImplementation) : base(printingImplementation) { }
        public override string Print() => PrintImplementation.Print("A");
    }
}
