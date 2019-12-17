using System.Collections.Generic;

namespace FlyweightPattern
{
    public class CoffeeFlavorFactory
    {
        private readonly Dictionary<string, CoffeeFlavor> _flavors = new Dictionary<string, CoffeeFlavor>();
        public CoffeeFlavor GetCoffeeFlavor(string flavorName)
        {
            if (_flavors.TryGetValue(flavorName, out var flavor)) return flavor;
            flavor = new CoffeeFlavor(flavorName);
            _flavors.Add(flavorName, flavor);
            return flavor;
        }
        public int GetTotalCoffeeFlavorsMade() => _flavors.Count;
    }
}
