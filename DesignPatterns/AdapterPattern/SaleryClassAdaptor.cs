namespace AdapterPattern
{
    public class PresidentClassAdaptor : PresidentOfTheBoard, ISalery
    {
        public PresidentClassAdaptor(int bonus) : base(bonus) { }
        public decimal GetSalery()
        {
            return GetBonuses();
        }
    }
}
