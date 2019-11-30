using System;

namespace Factory.Pizzas
{
    internal sealed class OlmaPizza : Pizza
    {
        internal OlmaPizza()
        {
            Name = "OlmaPizza";
            Dough = "Thin crust dough";
            Sauce = "Marinara sauce";
            Toppings.Add("Olma Chäs");
            Toppings.Add("Cervelat");
        }
        internal override void Cut() => Console.WriteLine("Pizza cutted to olma flag");
    }
}
