using Factory.Pizzas;

namespace Factory.Stores
{
    public sealed class StGallenPizzaFactory : IPizzaFactory
    {
        public Pizza CreatePizza() => new EspenPizza();
    }
}
