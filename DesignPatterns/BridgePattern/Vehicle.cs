namespace BridgePattern
{
    public abstract class Vehicle
    {
        protected IWorkshop Workshop1;
        protected IWorkshop Workshop2;
        protected Vehicle(IWorkshop workshop1, IWorkshop workshop2)
        {
            Workshop1 = workshop1;
            Workshop2 = workshop2;
        }
        public abstract bool Manufacture();
    }
}
