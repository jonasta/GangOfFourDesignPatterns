namespace Mediator
{
    internal static class Program
    {
        private static void Main()
        {
            ChatRoom chat = new();
            var Jhon = new Participant("Jhon");
            var Mary = new Participant("Mary");
            var Kyle = new Participant("Kyle");
            chat.Register(Jhon);
            chat.Register(Mary);
            chat.Register(Kyle);

            Jhon.Send(Mary, "Hi");
            Mary.Send(Jhon, "Hey!");
            Kyle.Send(Mary, "Nice to meet you!");
        }
    }
}