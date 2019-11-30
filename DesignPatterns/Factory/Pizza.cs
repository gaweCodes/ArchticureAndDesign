using System;
using System.Collections.Generic;

namespace Factory
{
    public abstract class Pizza
    {
        public string Name { get; protected set; }
        protected string Dough { get; set; }
        protected string Sauce { get; set; }
        protected List<string> Toppings = new List<string>();
        internal void Prepare()
        {
            Console.WriteLine($"Prepare {Name}");
            Console.WriteLine($"Toassing dough...");
            Console.WriteLine($"Adding sauce...");
            Console.WriteLine($"Adding toppings:");
            Toppings.ForEach(Console.WriteLine);
        }
        internal virtual void Bake() => Console.WriteLine("Bake pizza for 12 minutes at 220°C");
        internal virtual void Cut() => Console.WriteLine("Cutting pizza");
        internal void Box() => Console.WriteLine("Place pizza in effective PizzaStore box.");
    }
}
