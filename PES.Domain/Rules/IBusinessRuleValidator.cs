namespace PES.Domain.Rules
{
    public interface IBusinessRuleValidator
    {
        void Validate(BusinessRule rule);
    }
}