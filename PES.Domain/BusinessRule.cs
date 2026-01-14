using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PES.Domain
{
    public abstract class BusinessRule
    {
        public abstract bool IsBroken();
        public abstract string Message { get; }
    }
}