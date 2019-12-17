using BridgePattern;
using NUnit.Framework;

namespace BridgePatternTest
{
    public class BikeTest
    {
        [Test]
        public void Bike_Manufacture_ReturnTrue()
        {
            var produce = new Produce();
            var assemble = new Assemble();
            var bike = new Bike(produce, assemble);
            var calculatedResult = bike.Manufacture();
            Assert.That(calculatedResult, Is.True);
        }
    }
}