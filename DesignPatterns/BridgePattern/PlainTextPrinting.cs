namespace BridgePattern
{
    public class PlainTextPrinting : IPrinting
    {
        public string Print(string textToPrint) => textToPrint;
    }
}
