using System.Collections.Generic;
using System.Linq;

namespace AdapterPattern
{
    public class EmployeeManager
    {
        private readonly List<IEmployee> _employeeList = new List<IEmployee>();
        public void Add(IEmployee employee)
        {
            _employeeList.Add(employee);
        }

        public void Remove()
        {
            _employeeList.RemoveAt(0);
        }

        public decimal PaySaleries()
        {
            return _employeeList.Sum(e => e.GetSalery());
        }

        public int CountEmployees()
        {
            return _employeeList.Count;
        }
    }
}
