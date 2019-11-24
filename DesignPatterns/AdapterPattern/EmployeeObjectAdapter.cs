namespace AdapterPattern
{
    public class EmployeeObjectAdapter : IEmployee
    {
        private readonly PresidentOfTheBoard _president;
        public EmployeeObjectAdapter(PresidentOfTheBoard president)
        {
            _president = president;
        }
        public decimal GetSalery() => _president.GetBonuses();
        //public decimal GetSalery()
        //{
        //    return _president.GetBonuses();
        //}
    }
}
