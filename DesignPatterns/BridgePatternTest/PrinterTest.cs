using BridgePattern;
using NUnit.Framework;

namespace BridgePatternTest
{
    public class PrinterTest
    {
        [Test]
        public void Printer_PrintPlain_ReturnsA()
        {
            var plainTextPrinting = new PlainTextPrinting();
            var printer = new Printer(plainTextPrinting);
            var calculatedResult = printer.Print();
            const string expectedResult = "A";
            Assert.That(calculatedResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Printer_PrintHtml_ReturnHtmlA()
        {
            var htmlPrinting = new HtmlTextPrinting();
            var printer = new Printer(htmlPrinting);
            var calculatedResult = printer.Print();
            const string expectedResult = "<p>A</p>";
            Assert.That(calculatedResult, Is.EqualTo(expectedResult));
        }
    }
}