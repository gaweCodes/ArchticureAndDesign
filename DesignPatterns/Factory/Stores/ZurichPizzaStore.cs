using Factory.Pizzas;

namespace Factory.Stores
{
    public sealed class ZurichPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string pizza)
        {
            switch (pizza)
            {
                case "Letzigrund":
                    return new LetzigrundPizza();
                default:
                    return new NullPizza();
            }
        }
    }
}
