using System;
using Facade.Subsystem;

namespace Facade
{
    class Program
    {
        internal static void Main()
        {
            var facade = new CarFacade();
            facade.CreateCompleteCar();
            Console.ReadKey();
        }
    }
}
