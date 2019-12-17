using System;

namespace BridgePattern
{
    public class Bike : Vehicle
    {
        public Bike(IWorkshop workshop1, IWorkshop workshop2) : base(workshop1, workshop2) { }
        public override bool Manufacture()
        {
            Console.WriteLine("Bike ");
            Workshop1.Work();
            Workshop2.Work();
            return true;
        }
    }
}
