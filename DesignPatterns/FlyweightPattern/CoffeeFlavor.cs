using System;

namespace FlyweightPattern
{
    public class CoffeeFlavor : ICoffeeOrder
    {
        public string Flavor { get; set; }
        public CoffeeFlavor(string flavor)
        {
            Flavor = flavor;
        }

        public string ServeCoffee(CoffeeOrderContext context) =>
            $"Serving Coffee flavor {Flavor} to table number {context.TableNumber}";
    }
}
