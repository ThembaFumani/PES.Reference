using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PES.Core
{
    public interface IClock
    {
        DateTime UtcNow { get; }
    }

    public class Clock : IClock
    {
        public DateTime UtcNow => DateTime.UtcNow;
    }
}