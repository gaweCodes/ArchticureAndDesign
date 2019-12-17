namespace FlyweightPattern
{
    public class CoffeeOrderContext
    {
        public int TableNumber { get; }
        public CoffeeOrderContext(int tableNumber)
        {
            TableNumber = tableNumber;
        }
    }
}
