using System.Collections.Generic;

namespace Mediator
{
    public class ChatRoom : IChatRoom
    {
        private readonly List<Participant> _participants = new();

        public void Register(Participant participant)
        {
            participant.ChatRoom = this;
            _participants.Add(participant);
        }

        public void Send(Participant from, Participant receiver, string message)
        {
            receiver.Receive(from, message);
        }
    }
}