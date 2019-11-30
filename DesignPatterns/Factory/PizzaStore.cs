using System;

namespace Factory
{
    public abstract class PizzaStore
    {
        protected abstract Pizza CreatePizza(string type);

        public Pizza OrderPizza(string type)
        {
            var createdPizza = CreatePizza(type);
            Console.WriteLine($"Making pizza {createdPizza.Name}");
            createdPizza.Prepare();
            createdPizza.Bake();
            createdPizza.Cut();
            createdPizza.Box();
            return createdPizza;
        }
    }
}
