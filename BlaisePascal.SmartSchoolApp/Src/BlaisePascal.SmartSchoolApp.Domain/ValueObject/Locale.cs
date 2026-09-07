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
                var culture = CultureInfo.GetCultureInfo(value); //Ho trovato questa funzione e questa classe , che dato lo stato , per esempio it-IT non da errore e restituisce l'oggetto , ma se passi una stringa inventata lancia un eccezzione di tipo "CultureNotFoundException"
                return !culture.Equals(CultureInfo.InvariantCulture);  // Invariant Culture sono det. codici che possono contare come validi al primo controllo , ma possono non esserlo , es "" , comunque tengo il controllo IsNullOrWhiteSpace solo per dare + tipi di errori e non uno solo
            }
            catch (ArgumentException)
            {
                return false;
            }
        }
    }
}
