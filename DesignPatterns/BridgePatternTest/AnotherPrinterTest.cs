using BridgePattern;
using NUnit.Framework;

namespace BridgePatternTest
{
    public class AnotherPrinterTest
    {
        [Test]
        public void AnotherPrinter_PrintPlain_ReturnsB()
        {
            var plainTextPrinting = new PlainTextPrinting();
            var printer = new AnotherPrinter(plainTextPrinting);
            var calculatedResult = printer.Print();
            const string expectedResult = "B";
            Assert.That(calculatedResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void AnotherPrinter_PrintHtml_ReturnHtmlB()
        {
            var htmlPrinting = new HtmlTextPrinting();
            var printer = new AnotherPrinter(htmlPrinting);
            var calculatedResult = printer.Print();
            const string expectedResult = "<p>B</p>";
            Assert.That(calculatedResult, Is.EqualTo(expectedResult));
        }
    }
}