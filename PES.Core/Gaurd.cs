using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace PES.Core
{
    public static class Gaurd
    {
        public static void AgainstNull(object argument, string name)
        {
            if (argument == null)
                throw new ArgumentNullException();
        }

        public static void AgainstNullOrEmpty(string argument, string name)
        {
            if (string.IsNullOrWhiteSpace(argument))
                throw new ArgumentException($"{name} cannot be null or empty");
        }

        public static void AgainstOutOfRange(int value, int min, int max, string name)
        {
            if (value < min || value > max)
                throw new ArgumentOutOfRangeException(name, $"{name} must be between {min} and {max};.");
        }
    }
}