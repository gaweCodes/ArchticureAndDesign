using System;
using Composite;

namespace Decorator
{
    public class EnglishLoggingDecorator : LoggingDecorator
    {
        public EnglishLoggingDecorator(IEmployee employee) : base(employee)
        {
        }
        public override void ShowEmployeeDetails()
        {
            Directory.ShowEmployeeDetails();
            Console.WriteLine($"Company or Section name {((CompanyDirectory)Directory).Name}");
        }
    }
}
