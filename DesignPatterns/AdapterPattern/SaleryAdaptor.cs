using System.Collections.Generic;
using System.Linq;

namespace AdapterPattern
{
    public class SaleryAdaptor : ISalery
    {
        private readonly PresidentOfTheBoard _president;

        public SaleryAdaptor(PresidentOfTheBoard president)
        {
            _president = president;
        }
        public decimal GetSalery()
        {
            return _president.GetBonuses();
        }
    }
}
