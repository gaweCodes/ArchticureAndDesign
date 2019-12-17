using BridgePattern;
using NUnit.Framework;

namespace BridgePatternTest
{
    public class CarTest
    {
        [Test]
        public void Car_Manufacture_ReturnsTrue()
        {
            var produce = new Produce();
            var assemble = new Assemble();
            var car = new Car(produce, assemble);
            var calculatedResult = car.Manufacture();
            Assert.That(calculatedResult, Is.True);
        }
    }
}