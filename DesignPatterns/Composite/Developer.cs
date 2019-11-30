using System;

namespace Composite
{
    /// <summary>
    /// Leave
    /// </summary>
    public class Developer : IEmployee
    {
        private readonly string _name;
        private readonly long _empId;
        public Developer(long empId, string name)
        {
            this._empId = empId;
            this._name = name;
        }
        public void ShowEmployeeDetails() => Console.WriteLine($"Id: {_empId} Name: {_name}");
    }
}
