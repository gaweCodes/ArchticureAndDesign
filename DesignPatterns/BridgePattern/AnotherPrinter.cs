namespace BridgePattern
{
    public class AnotherPrinter : Printer
    {
        public AnotherPrinter(IPrinting printingImplementation) : base(printingImplementation) { }
        public override string Print() => PrintImplementation.Print("B");
    }
}
