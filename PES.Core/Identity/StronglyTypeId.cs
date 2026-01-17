using PES.Core.Gaurding;

namespace PES.Core.Identity
{
    public abstract class StronglyTypeId<T>
    {
        public T Value { get; }

        protected StronglyTypeId(T value)
        {
            Gaurd.AgainstNull(value, nameof(value));
            Value = value;
        }

        public override string ToString() => Value.ToString();
        public override bool Equals(object obj) 
            => obj is StronglyTypeId<T> other && Value.Equals(other.Value);
        public override int GetHashCode() => Value.GetHashCode();

        public static implicit operator T(StronglyTypeId<T> id) => id.Value;
    }
}