using BlaisePascal.SmartSchoolApp.SharedKernel;
using System;

namespace BlaisePascal.SmartSchoolApp.Domain.Abstractions // <-- Rimosso .Error finale
{
    public record SessionErrors : Error
    {
        public static readonly Error AlreadyRevoked = new("Session.AlreadyRevoked", "The session has already been revoked.", ErrorType.Conflict);
        public static readonly Error NotFounds = new("Session.NotFound", "The specified session was not found.", ErrorType.NotFound); //NotFound era una parola chiave , quindi non la ho usata

        public SessionErrors(string code, string description, ErrorType type) : base(code, description, type)
        {
        }
    }
}