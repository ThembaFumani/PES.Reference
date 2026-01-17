namespace PES.Domain.Specification
{
    public abstract class Specification<T>
    {
        public abstract bool IsSatisfiedBy(T entity);

        public Specification<T> And(Specification<T> other)
            => new AndSpecification<T>(this, other);


    }

    internal sealed class AndSpecification<T> : Specification<T>
    {
        private Specification<T> _specification;
        private Specification<T> _other;

        public AndSpecification(Specification<T> specification, Specification<T> other)
        {
            _specification = specification;
            _other = other;
        }

        public override bool IsSatisfiedBy(T entity) => 
            _specification.IsSatisfiedBy(entity) && _other.IsSatisfiedBy(entity);
    }

    internal sealed class OrSpecification<T> : Specification<T>
    {
        private Specification<T> _specification;
        private Specification<T> _other;

        public OrSpecification(Specification<T> specification, Specification<T> other)
        {
            
            _specification = specification;
            _other = other;
        }

        public override bool IsSatisfiedBy(T entity) => 
            _specification.IsSatisfiedBy(entity) || _other.IsSatisfiedBy(entity);
    }

    internal sealed class NotSpecification<T> : Specification<T>
    {
        private Specification<T> _specification;

        public NotSpecification(Specification<T> specification)
        {
            _specification = specification;
        }
        
        public override bool IsSatisfiedBy(T entity) => 
            !_specification.IsSatisfiedBy(entity);
    }
}