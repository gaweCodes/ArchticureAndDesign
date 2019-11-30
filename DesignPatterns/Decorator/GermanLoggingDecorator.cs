using System;
using Composite;

namespace Decorator
{
    public class GermanLoggingDecorator : LoggingDecorator
    {
        public GermanLoggingDecorator(IEmployee directory) : base(directory)
        {
        }

        public override void ShowEmployeeDetails()
        {
            Directory.ShowEmployeeDetails();
            Console.WriteLine($"Firma bzw. Abteilungsname {((CompanyDirectory)Directory).Name}");
        }
    }
}
