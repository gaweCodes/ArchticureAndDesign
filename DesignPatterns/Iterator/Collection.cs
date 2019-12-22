using System.Collections;

namespace Iterator
{
    internal class Collection : IAbstractCollection
    {
        private readonly ArrayList _items = new ArrayList();
        public Iterator CreateIterator() => new Iterator(this);
        public int Count
        {
            get => _items.Count;
        }

        public object this[int index]
        {
            get => _items[index];
            set => _items.Add(value);
        }
    }
}
