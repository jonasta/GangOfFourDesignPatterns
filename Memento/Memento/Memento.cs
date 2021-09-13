namespace Memento
{
    public class Memento
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public decimal Budget { get; set; }

        public Memento(string name, string phone, decimal budget)
        {
            Name = name;
            Phone = phone;
            Budget = budget;
        }
    }
}