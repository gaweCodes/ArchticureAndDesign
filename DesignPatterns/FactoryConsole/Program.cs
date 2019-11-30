using System;
using System.Collections.Generic;
using System.Linq;
using Factory;
using Factory.Stores;

namespace FactoryConsole
{
    internal class Program
    {
        private static void Main()
        {
            var sgStore = new StGallenPizzaStore();
            var zhStore = new ZurichPizzaStore();
            var pizzaList = new List<Pizza>
            {
                sgStore.OrderPizza("Olma"),
                sgStore.OrderPizza("Espen"),
                sgStore.OrderPizza("Bratwurst"),
                zhStore.OrderPizza("Letzigrund"),
                sgStore.OrderPizza("asdf")
            };
            Console.WriteLine($"Invalid Pizzas: {pizzaList.Count(p => p.Name == "NullPizza")}");
            pizzaList.Where(p => p.Name != "NullPizza").ToList().ForEach(p => Console.WriteLine(p.Name));
        }
    }
}
