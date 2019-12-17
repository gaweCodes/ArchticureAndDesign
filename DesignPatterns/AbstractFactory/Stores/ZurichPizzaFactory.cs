using AbstractFactory.Pizzas;

namespace AbstractFactory.Stores
{
    public sealed class ZurichPizzaFactory : PizzaStore
    {
        public override Pizza CreatePizza() => new LetzigrundPizza();
    }
}
