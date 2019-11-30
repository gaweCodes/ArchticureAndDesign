using System;

namespace Factory.Pizzas
{
    internal sealed class EspenPizza : Pizza
    {
        internal EspenPizza()
        {
            Name = "EspenPizza";
            Dough = "speciale";
            Sauce = "Espen sauce";
            Toppings.Add("White");
            Toppings.Add("Green");
        }

        internal override void Bake() => Console.WriteLine("Bake only 5 minutes.");
    }
}
