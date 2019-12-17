namespace AbstractFactory.Pizzas
{
    internal sealed class EspenPizza : Pizza
    {
        internal EspenPizza()
        {
            Name = "EspenPizza";
            Add("Mashrooms");
            Add("Gurken");
        }
    }
}
