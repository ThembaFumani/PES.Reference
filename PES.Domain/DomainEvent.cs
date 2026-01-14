using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PES.Domain
{
    public abstract class DomainEvent
    {
        public DateTime OccuredOn { get; }

        protected DomainEvent()
        {
            OccuredOn = DateTime.UtcNow;
        }
    }
}