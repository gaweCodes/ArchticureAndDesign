using System;
using System.Configuration;
using System.Reflection;

namespace Factory
{
    internal class Program
    {
        private static void Main()
        {
            var location = ConfigurationManager.AppSettings["location"];
            var type = Assembly.GetExecutingAssembly().GetType($"Factory.Stores.{location}PizzaFactory");
            var pizzaFactory = (IPizzaFactory) type.GetConstructor(Array.Empty<Type>())?.Invoke(Array.Empty<object>());
            // IPizzaFactory pizzaFactory = (IPizzaFactory)Activator.CreateInstance(type);
            // var pizzaFactory = new StGallenPizzaFactory();

            var pizzaStore = new PizzaStore(pizzaFactory);
            var pizza = pizzaStore.CreatePizza();
            Console.WriteLine($"{pizza.Name} created");
            Console.ReadLine();
        }
    }
}
