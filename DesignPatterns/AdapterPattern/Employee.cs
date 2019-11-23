namespace AdapterPattern
{
    public class Employee
    {
        private readonly decimal _salery;
        public Employee(decimal salery)
        {
            _salery = salery;
        }
        public decimal GetSalery()
        {
            return _salery;
        }
    }
}
