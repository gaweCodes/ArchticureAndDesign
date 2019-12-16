namespace BridgePattern
{
    public class AnotherPrinter : Printer
    {
        public AnotherPrinter(IPrinting printingImplementation) : base(printingImplementation) { }
        public override void Print() => PrintImplementation.Print("B");
    }
}
