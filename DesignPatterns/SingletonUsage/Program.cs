using System.Threading;
using Singleton;

namespace SingletonUsage
{
    internal class Program
    {
        private static void Main()
        {
            new Thread(new NumberPrinter().StartPrinting).Start();
            new Thread(new TextPrinter().StartPrinting).Start();
        }
    }
}
