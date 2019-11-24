namespace AdapterPattern
{
    public class PresidentOfTheBoard
    {
        private readonly decimal _bonus;

        public PresidentOfTheBoard(decimal bonus)
        {
            _bonus = bonus;
        }

        public decimal GetBonuses() => _bonus;
        //public decimal GetBonuses()
        //{
        //    return _bonus;
        //}
    }
}
