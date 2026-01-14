using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PES.Domain
{
    public interface IBusinessRuleValidator
    {
        void Validate(BusinessRule rule);
    }
}