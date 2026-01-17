namespace PES.Domain.Events
{
    public interface IDomainEventHandler<T> where T: DomainEvent
    {
        void Handle(T @event);
    }
}