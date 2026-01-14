using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PES.Core;

namespace PES.Domain
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