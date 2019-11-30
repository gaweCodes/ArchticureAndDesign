using Factory.Pizzas;

namespace Factory.Stores
{
    public sealed class StGallenPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string pizza)
        {
            switch (pizza)
            {
                case "Olma":
                    return new OlmaPizza();
                case "Bratwurst":
                    return new BratwurstPizza();
                case "Espen":
                    return new EspenPizza();
                default:
                    return new NullPizza();
            }
        }
    }
}
