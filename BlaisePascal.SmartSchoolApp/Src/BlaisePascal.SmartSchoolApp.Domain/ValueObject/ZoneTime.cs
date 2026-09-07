using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ValueObject
{
    public record ZoneTime
    {
        public string Value { get; }

        private ZoneTime(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Timezone cannot be empty.", nameof(value));

            if (!IsValidTimeZone(value))
                throw new ArgumentException($"'{value}' is not a valid timezone identifier.", nameof(value));

            Value = value;
        }

        public static ZoneTime Create(string value) => new(value);

        private static bool IsValidTimeZone(string value)
        {
            try
            {
                TimeZoneInfo.FindSystemTimeZoneById(value); //Come in Locale ho trovato una classe con una funzione che ti controlla se il fusorario dato esiste , se non c'è va al catch e ritorna falso
                return true;
            }
            catch (TimeZoneNotFoundException)
            {
                return false; //Il fusorario non esiste
            }
        }
    }
}
