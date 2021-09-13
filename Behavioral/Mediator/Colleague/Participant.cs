using System;

namespace Mediator
{
    public class Participant
    {
        private string Name { get; }
        public ChatRoom ChatRoom { get; set; }

        public Participant(string name)
        {
            Name = name;
        }

        public void Send(Participant to, string message)
        {
            ChatRoom.Send(this, to, message);
        }

        internal void Receive(Participant from, string message)
        {
            Console.WriteLine($"{from.Name} sent to {Name}: {message}");
        }
    }
}