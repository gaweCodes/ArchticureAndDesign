namespace Factory.Pizzas
{
    internal sealed class LetzigrundPizza : Pizza
    {
        internal LetzigrundPizza()
        {
            Name = "Letzigrund Pizza";
            Dough = "Thin";
            Sauce = "Senf";
            Toppings.Add("Bären");
        }
    }
}
