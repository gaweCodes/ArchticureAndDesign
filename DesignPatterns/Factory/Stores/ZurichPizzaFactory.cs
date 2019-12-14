using Factory.Pizzas;

namespace Factory.Stores
{
    public sealed class ZurichPizzaFactory : IPizzaFactory
    {
        public Pizza CreatePizza() => new LetzigrundPizza();
    }
}
