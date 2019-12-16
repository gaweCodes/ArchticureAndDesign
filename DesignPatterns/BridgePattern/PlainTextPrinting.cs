using System;

namespace BridgePattern
{
    public class PlainTextPrinting : IPrinting
    {
        public void Print(string textToPrint) => Console.WriteLine(textToPrint);
    }
}
