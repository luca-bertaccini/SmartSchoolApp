using System.Globalization;

namespace Domain.ValueObject
{
    public record Locale
    {
        public string Value { get; }

        public Locale(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("You Have to indicate your state of belonging , for example it-IT");

            if (!IsValidCulture(value))
                throw new ArgumentException($"The state gaved '{value}' is not valid");

            Value = value;
        }

        public static Locale Create(string value) => new(value);

        private static bool IsValidCulture(string value)
        {
            try
            {
                var culture = CultureInfo.GetCultureInfo(value);
                return !culture.Equals(CultureInfo.InvariantCulture);  
            }
            catch (ArgumentException)
            {
                return false;
            }
        }
    }
}
