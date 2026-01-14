using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PES.Domain
{
    public interface IDomainEventHandler<T> where T: DomainEvent
    {
        void Handle(T @event);
    }
}