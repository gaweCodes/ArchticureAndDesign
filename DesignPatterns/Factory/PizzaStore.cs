using System;

namespace Factory
{
    public class PizzaStore
    {
        private readonly IPizzaFactory _pizzaFactory;
        public PizzaStore(IPizzaFactory pizzaFactory)
        {
            _pizzaFactory = pizzaFactory;
        }
        public Pizza CreatePizza() => _pizzaFactory.CreatePizza();
    }
}
