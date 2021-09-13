namespace Iterator
{
    public class Iterator : IIterator
    {
        private readonly Collection _collection;
        private int _current = 0;
        public int Step { get; set; }

        public Iterator(Collection collection)
        {
            _collection = collection;
            Step = 1;
        }

        public Item CurrentItem => _collection[_current];

        public Item First()
        {
            _current = 0;
            return _collection[_current];
        }

        public bool IsDone() => _current > _collection.Count - 1;

        public Item Next()
        {
            _current += Step;
            if (!IsDone()) return _collection[_current];
            return null;
        }
    }
}