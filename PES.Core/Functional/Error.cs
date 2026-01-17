using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PES.Core.Functional
{
    public sealed class Error
    {
        public string? Code { get; set; }
        public string? Message { get; set; }

        private Error(string code, string message)
        {
            Code = code;
            Message = message;
        }

        public static Error None() => new Error(string.Empty, string.Empty);

        public static Error Create(string code, string message)
        {
            Gaurd.AgainstNullOrEmpty(code, nameof(code));
            Gaurd.AgainstNullOrEmpty(message, nameof(message));
            return new Error(code, message);
        }
    }
}