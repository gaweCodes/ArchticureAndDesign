using System;
using System.Collections.Generic;

namespace Composite
{
    /// <summary>
    /// Composite
    /// </summary>
    public class CompanyDirectory : IEmployee
    {
        public string Name { get; private set; }

        public CompanyDirectory(string name)
        {
            Name = name;
        }
        private readonly List<IEmployee> _employeeList = new List<IEmployee>();

        public void ShowEmployeeDetails()
        {
            Console.WriteLine(Name);
            _employeeList.ForEach(e => e.ShowEmployeeDetails());
        }

        public void AddEmployee(IEmployee emp) => _employeeList.Add(emp);
        public void RemoveEmployee(IEmployee emp) => _employeeList.Remove(emp);
    }
}
