using System;
using System.Configuration;
using System.Reflection;
// using AbstractFactory.Stores;

namespace AbstractFactory
{
    internal class Program
    {
        private static void Main()
        {
            var location = ConfigurationManager.AppSettings["location"];
            var type = Assembly.GetExecutingAssembly().GetType($"AbstractFactory.Stores.{location}PizzaFactory");
            var pizzaStore = (PizzaStore) type.GetConstructor(Array.Empty<Type>())?.Invoke(Array.Empty<object>());
            // var pizzaStore = (PizzaStore)Activator.CreateInstance(type);
            // var pizzaStore = new StGallenPizzaFactory();

            var pizza = pizzaStore?.CreatePizza();
            Console.WriteLine($"{pizza?.Name} created");
            Console.ReadLine();
        }
    }
}
