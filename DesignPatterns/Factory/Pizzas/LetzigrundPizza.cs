namespace Factory.Pizzas
{
    internal sealed class LetzigrundPizza : Pizza
    {
        internal LetzigrundPizza()
        {
            Name = "Letzigrund Pizza";
            Add("Senf");
            Add("Lions");
        }
    }
}
