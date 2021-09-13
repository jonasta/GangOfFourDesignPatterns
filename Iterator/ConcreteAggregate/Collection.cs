using System.Collections.Generic;

namespace Iterator
{
    public class Collection : ICollection
    {
        private readonly List<Item> _items = new();

        public Item this[int index]
        {
            get { return _items[index]; }
            set { _items.Add(value); }
        }

        public int Count
        {
            get { return _items.Count; }
        }

        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }
    }
}