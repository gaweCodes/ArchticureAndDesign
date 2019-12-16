namespace BridgePattern
{
    public abstract class AbstractPrinter
    {
        public IPrinting PrintImplementation { get; set; }

        public AbstractPrinter(IPrinting printingImplementation)
        {
            PrintImplementation = printingImplementation;
        }
        public abstract void Print();
    }
}
