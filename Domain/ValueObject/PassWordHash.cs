using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ValueObject
{
    public record PasswordHash
    {
        public string Value { get; }
        private const int MinLength = 16; 
        private const int MaxLength = 32;

        private PasswordHash(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Password cannot be empty.", nameof(value));
            if (value.Length < MinLength || value.Length > MaxLength)
                throw new ArgumentException("The Password has to be between 16 and 32 figures" , nameof( value));

            Value = value; 
        }
        public static PasswordHash Create(string hash) => new(hash);
    }
}
