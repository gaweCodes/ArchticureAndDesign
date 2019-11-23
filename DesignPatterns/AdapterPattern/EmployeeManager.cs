using System.Collections.Generic;
using System.Linq;

namespace AdapterPattern
{
    public class EmployeeManager
    {
        private readonly List<Employee> _employeeList = new List<Employee>();
        public void Add(Employee employee)
        {
            _employeeList.Add(employee);
        }

        public void Remove()
        {
            _employeeList.RemoveAt(0);
        }

        public decimal PaySaleries(SaleryAdaptor adaptor)
        {
            return _employeeList.Sum(e => e.GetSalery()) + adaptor.GetSalery();
        }

        public decimal PaySaleries(PresidentClassAdaptor adaptor)
        {
            return _employeeList.Sum(e => e.GetSalery()) + adaptor.GetSalery();
        }

        public int CountEmployees()
        {
            return _employeeList.Count;
        }
    }
}
