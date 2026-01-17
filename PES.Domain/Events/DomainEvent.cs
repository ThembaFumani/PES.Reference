namespace PES.Domain.Events
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