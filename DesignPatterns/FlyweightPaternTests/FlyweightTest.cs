using NUnit.Framework;

namespace FlyweightPattern.Tests
{
    public class FlyweightTest
    {
        private readonly CoffeeFlavor[] _flavors = new CoffeeFlavor[100];
        private readonly CoffeeOrderContext[] _tables = new CoffeeOrderContext[100];
        private int _ordersMade;
        private CoffeeFlavorFactory _flavorFactory;
        private void TakeOrders(string flavorIn, int table)
        {
            _flavors[_ordersMade] = _flavorFactory.GetCoffeeFlavor(flavorIn);
            _tables[_ordersMade++] = new CoffeeOrderContext(table);
        }

        [Test]
        public void CoffeFlavor_ServeCoffeWithFlavorToSpecificTable_ReturnFlavorAndTableName()
        {
            _flavorFactory = new CoffeeFlavorFactory();
            TakeOrders("Cappuccino", 2);
            /*TakeOrders("Cappuccino", 2);
            TakeOrders("Frappe", 1);
            TakeOrders("Frappe", 1);
            TakeOrders("Xpresso", 1);
            TakeOrders("Frappe", 897);
            TakeOrders("Cappuccino", 97);
            TakeOrders("Cappuccino", 97);
            TakeOrders("Frappe", 3);
            TakeOrders("Xpresso", 3);
            TakeOrders("Cappuccino", 3);
            TakeOrders("Xpresso", 96);
            TakeOrders("Frappe", 552);
            TakeOrders("Cappuccino", 121);
            TakeOrders("Xpresso", 121);*/

            var calculatedResult = _flavors[0].ServeCoffee(_tables[0]);
            const string expectedResult = "Serving Coffee flavor Cappuccino to table number 2";
            Assert.That(calculatedResult, Is.EqualTo(expectedResult));
        }
    }
}