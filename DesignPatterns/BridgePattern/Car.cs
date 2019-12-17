using System;

namespace BridgePattern
{
    public class Car : Vehicle
    {
        public Car(IWorkshop workshop1, IWorkshop workshop2) : base(workshop1, workshop2) { }

        public override bool Manufacture()
        {
            Console.WriteLine("Car ");
            Workshop1.Work();
            Workshop2.Work();
            return true;
        }
    }
}
