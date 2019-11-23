using System.Threading;

namespace Singleton
{
    public class NumberPrinter
    {
        public void StartPrinting()
        {
            while (true)
            {
                if (!PrinterSpooler.TryGetInstance(out var printerSpoolerInstance)) continue;
                using (printerSpoolerInstance.ResourceHandle)
                {
                    printerSpoolerInstance.Print(new PrintJob("Number"));
                    Thread.Sleep(2000);
                }
            }
        }
    }
}
