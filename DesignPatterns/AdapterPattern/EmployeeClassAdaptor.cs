namespace AdapterPattern
{
    public class EmployeeClassAdaptor : Employee
    {
        public EmployeeClassAdaptor(PresidentOfTheBoard president) : base(president.GetBonuses()) { }
    }
}
