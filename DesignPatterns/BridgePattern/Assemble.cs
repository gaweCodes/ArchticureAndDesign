using System;

namespace BridgePattern
{
    public class Assemble : IWorkshop
    {
        public void Work() => Console.WriteLine($"And{Environment.NewLine}Assemblied");
    }
}
