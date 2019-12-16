using BridgePattern;
using NUnit.Framework;

namespace BridgePatternTest
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Printer printer;
            var plainTextPrinting = new PlainTextPrinting();
            var htmlPrinting = new HtmlTextPrinting();

            printer = new Printer(plainTextPrinting);
            printer.Print();
            
            printer.PrintImplementation = htmlPrinting;
            printer.Print();

            /* Genauso kann (ähnlich wie beim Strategy-Pattern) der
             * Printer selbst zur Laufzeit geändert werden. */
            printer = new BPrinter(plainImpl);
            printer.print();

            printer.setImpl(htmlImpl);
            printer.print();
        }
    }
}