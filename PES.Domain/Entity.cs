using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PES.Core;

namespace PES.Domain
{
    public abstract class Entity<TId>
    {
        public TId? Id { get; set; }

        protected Entity(TId id)
        {
            Gaurd.AgainstNull(id, nameof(id));
            Id = id;
        }

        public override bool Equals(object? obj)
        {
            if (obj is not Entity<TId> other) return false;
            if (ReferenceEquals(this, other)) return true;
            return Id.Equals(other.Id);
        }

        public override int GetHashCode() => Id.GetHashCode();
    }
}