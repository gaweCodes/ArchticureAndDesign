namespace BridgePattern
{
    public abstract class AbstractPrinter
    {
        public IPrinting PrintImplementation { get; }
        protected AbstractPrinter(IPrinting printingImplementation)
        {
            PrintImplementation = printingImplementation;
        }

        public abstract string Print();
    }
}
