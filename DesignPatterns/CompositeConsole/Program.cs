using Composite;

namespace CompositeConsole
{
    /// <summary>
    /// Client
    /// </summary>
    internal class Program
    {
        private static void Main()
        {
            var dev1 = new Developer(100, "Lokesh Sharma");
            var dev2 = new Developer(101, "Vinay Sharma");
            var engDirectory = new CompanyDirectory("Engineering");
            var webDirectory = new CompanyDirectory("Web");
            engDirectory.AddEmployee(webDirectory);
            webDirectory.AddEmployee(dev1);
            engDirectory.AddEmployee(dev2);
            engDirectory.AddEmployee(dev1);

            var man1 = new Manager(200, "Kushagra Garg");
            var man2 = new Manager(201, "Vikram Sharma ");
            var accDirectory = new CompanyDirectory("Managers");
            accDirectory.AddEmployee(man1);
            accDirectory.AddEmployee(man2);

            var directory = new CompanyDirectory("Rey Automation");
            directory.AddEmployee(engDirectory);
            directory.AddEmployee(accDirectory);
            directory.ShowEmployeeDetails();
        }
    }
}
