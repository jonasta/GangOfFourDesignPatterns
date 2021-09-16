using System.Collections.Generic;

namespace Strategy
{
    public class SortedList
    {
        private readonly List<string> _list = new();
        private SortStrategy _sortStrategy;

        internal void Add(string student)
        {
            _list.Add(student);
        }

        public void SetSortStrategy(SortStrategy sortStrategy)
        {
            _sortStrategy = sortStrategy;
        }

        internal void Sort()
        {
            _sortStrategy.Sort(_list);
        }
    }
}