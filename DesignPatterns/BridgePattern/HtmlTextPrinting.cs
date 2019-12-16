using System;

namespace BridgePattern
{
    public class HtmlTextPrinting : IPrinting
    {
        public void Print(string textToPrint) => Console.WriteLine($"<p>{textToPrint}</p>");
    }
}
