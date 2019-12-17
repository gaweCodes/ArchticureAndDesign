using System;

namespace BridgePattern
{
    public class Produce : IWorkshop
    {
        public void Work() => Console.WriteLine("Produced");
    }
}
