using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ValueObject
{
    public record Email
    {
        public string Value { get; set; }

        private Email(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Value cannot be empty", nameof(value));

            if (!value.Contains("@gmail.com"))
                throw new ArgumentException("The Email has to contain @gmail.com to be authorized", nameof(value));

            Value = value;
        }
        public Email Create(string value) => new Email(value);
    }
}
