using AbstractFactory.Pizzas;

namespace AbstractFactory.Stores
{
    public sealed class StGallenPizzaFactory : PizzaStore
    {
        public override Pizza CreatePizza() => new EspenPizza();
    }
}
