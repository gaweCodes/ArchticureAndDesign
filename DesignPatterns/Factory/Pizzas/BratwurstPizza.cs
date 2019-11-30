namespace Factory.Pizzas
{
    internal sealed class BratwurstPizza : Pizza
    {
        internal BratwurstPizza()
        {
            Name = "BratwurstPizza";
            Dough = "thick";
            Sauce = "Ketchup";
            Toppings.Add("Bratwurst");
        }
    }
}
