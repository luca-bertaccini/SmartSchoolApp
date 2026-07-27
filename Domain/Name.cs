using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public record Name 
    {
        public string Value { get; }

        private Name(string value) 
        {
            if(string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Value cannot be empty", nameof(value));
            Value = value;
        }

        public Name Create(string value) => new Name(value);
    }
} 
