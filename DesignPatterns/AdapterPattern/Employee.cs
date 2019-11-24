namespace AdapterPattern
{
    public class Employee : IEmployee
    {
        private readonly decimal _salery;

        public Employee(decimal salery)
        {
            _salery = salery;
        }

        public decimal GetSalery() => _salery;
        // public decimal GetSalery()
        // { 
        //    return _salery;
        // }
    }
}
