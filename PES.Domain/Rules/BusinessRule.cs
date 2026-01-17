namespace PES.Domain.Rules
{
    public abstract class BusinessRule
    {
        public abstract bool IsBroken();
        public abstract string Message { get; }
    }
}