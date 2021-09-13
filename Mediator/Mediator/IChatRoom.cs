namespace Mediator
{
    public interface IChatRoom
    {
        void Register(Participant participant);

        void Send(Participant from, Participant receiver, string message);
    }
}