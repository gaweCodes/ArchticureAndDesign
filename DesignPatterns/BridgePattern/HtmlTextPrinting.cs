namespace BridgePattern
{
    public class HtmlTextPrinting : IPrinting
    {
        public string Print(string textToPrint) => $"<p>{textToPrint}</p>";
    }
}
