using System.Threading;

namespace Singleton
{
    public class TextPrinter
    {
        public void StartPrinting()
        {
            while (true)
            {
                if (!PrinterSpooler.TryGetInstance(out var printerSpoolerInstance)) continue;
                using (printerSpoolerInstance.ResourceHandle)
                {
                    printerSpoolerInstance.Print(new PrintJob("Text"));
                    Thread.Sleep(3000);
                }
            }
        }
    }
}
