using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace PES.Core.Gaurding
{
    public static class Gaurd
    {
        public static void AgainstNull(object argument, string name)
        {
            if (argument is null)
                throw new ArgumentNullException(name);
        }

        public static void AgainstNullOrEmpty(string argument, string name)
        {
            if (string.IsNullOrWhiteSpace(argument))
                throw new ArgumentException($"{name} cannot be null or empty");
        }

        public static void AgainstOutOfRange<T>(T value, T min, T max, string name)
            where T : IComparable<T>
        {
            if (value.CompareTo(min) < 0 || value.CompareTo(max) > 0)
                throw new ArgumentOutOfRangeException(name, $"{name} must be between {min} and {max};.");
        }

        public static void Againt(bool condition, string message)
        {
            if (condition)
                throw new InvalidOperationException(message);
        }
    }
}