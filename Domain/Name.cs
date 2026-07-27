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

        public Name(string value) 
        {
            if(string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Il nome non può essere vuoto", nameof(value));
        } 
    }
} 
