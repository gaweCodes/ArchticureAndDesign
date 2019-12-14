using System.Collections.Generic;

namespace Factory
{
    public abstract class Pizza
    {
        private readonly HashSet<string> _toppings;
        public string Name { get; protected set; }
        protected IReadOnlyCollection<string> Toppings => _toppings;
        protected Pizza()
        {
            _toppings = new HashSet<string>();
            Add("Mozzarella");
            Add("Tomato");
        }
        public void Add(string ingredient) => _toppings.Add(ingredient);
    }
}
