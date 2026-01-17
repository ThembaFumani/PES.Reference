
using PES.Core.Gaurding;
using PES.Domain.Events;

namespace PES.Domain.Common
{
    public abstract class AggregateRoot<TId> : Entity<TId>
    {
        private readonly List<DomainEvent> _domainEvents = new();
        private IReadOnlyCollection<DomainEvent> DomainEvents => _domainEvents.AsReadOnly();

        protected AggregateRoot(TId id) : base(id) { }

        protected void AddDomainEvent(DomainEvent domainEvent)
        {
            Gaurd.AgainstNull(domainEvent, nameof(domainEvent));
            _domainEvents.Add(domainEvent);
        }

        public void ClearDomainEvents() => _domainEvents.Clear(); 
    }
}