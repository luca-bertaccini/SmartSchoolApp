using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ValueObject
{
    public record Address
    {
        public string Street { get; } //Tutto ciò che ha un indirizzo
        public string CAP { get; }
        public string Country { get; }
        public string City { get; }

        private Address(string street , string city , string country , string cap)
        {
            if (string.IsNullOrWhiteSpace(street))
                throw new ArgumentException("Value cannot be empty", nameof(street));
            Street = street;

            if (string.IsNullOrWhiteSpace(city))
                throw new ArgumentException("Value cannot be empty", nameof(city));
            City = city;

            if (string.IsNullOrWhiteSpace(country))
                throw new ArgumentException("Value cannot be empty", nameof(country));
            Country = country;

            if (string.IsNullOrWhiteSpace(cap))
                throw new ArgumentException("Value cannot be empty", nameof(cap));
            CAP = cap;
        }

        public Address Create(string value , string city , string country , string cap) => new Address(value , city , country , cap);

    }
}
