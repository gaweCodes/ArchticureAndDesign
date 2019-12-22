namespace Iterator
{
    internal class Iterator : IAbstractIterator
    {
        private Collection _collection;
        private int _current = 0;
        public int Step { get; set; } = 1;
        public Item CurrentItem => _collection[_current] as Item;
        public bool IsDone => _current >= _collection.Count;
        public Iterator(Collection collection)
        {
            _collection = collection;
        }

        public Item First()
        {
            _current = 0;
            return _collection[_current] as Item;
        }
        public Item Next()
        {
            _current += Step;
            return !IsDone ? _collection[_current] as Item : null;
        }
    }
}
