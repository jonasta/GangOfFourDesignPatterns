namespace Strategy
{
    internal static class Program
    {
        private static void Main()
        {
            SortedList studentRecords = new();
            studentRecords.Add("Jhon");
            studentRecords.Add("Mary");
            studentRecords.Add("Philip");
            studentRecords.Add("Kleber");
            studentRecords.Add("Samual");
            studentRecords.Add("Jimmy");
            studentRecords.Add("Sandra");
            studentRecords.Add("Vivek");
            studentRecords.Add("Anna");

            studentRecords.SetSortStrategy(new QuickSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new ShellSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new MergeSort());
            studentRecords.Sort();
        }
    }
}