using Composite;
using Decorator;

namespace DecoratorConsole
{
    internal class Program
    {
        private static void Main()
        {
            IEmployee employeeGerman = new CompanyDirectory("Test German");
            employeeGerman.ShowEmployeeDetails();
            employeeGerman = new GermanLoggingDecorator(employeeGerman);
            employeeGerman.ShowEmployeeDetails();

            IEmployee employeeEnglish = new CompanyDirectory("Test English");
            employeeEnglish = new EnglishLoggingDecorator(employeeEnglish);
            employeeEnglish.ShowEmployeeDetails();
        }
    }
}
