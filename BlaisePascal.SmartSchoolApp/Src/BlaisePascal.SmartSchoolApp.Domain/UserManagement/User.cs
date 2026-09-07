using System;
using BlaisePascal.SmartSchoolApp.SharedKernel;
using Domain.ValueObject; 
using BlaisePascal.SmartSchoolApp.Domain.UserManagement.Repository; 

namespace Domain.UserManagement
{
    public class User
    {
        public Guid UserId { get; private set; }
        public Email Email { get; private set; }
        public ZoneTime TimeZone { get; private set; }
        public Locale State { get; private set; }
        public PasswordHash PasswordHash { get; private set; } 

        private User() 
        { 

        }

        public User(ZoneTime timeZone, Email email, Locale state, PasswordHash passwordHash)
        {
            UserId = Guid.NewGuid();
            TimeZone = timeZone;
            Email = email;
            State = state;
            PasswordHash = passwordHash;
        }

        public Result VerifyPassword(string plainPassword, IPasswordHasher hasher)
        {
            var verifyResult = hasher.Verify(plainPassword, this.PasswordHash.Value);
            if (verifyResult.IsFailure)
            {
                return Result.Failure(Error.Conflict("User.InvalidCredentials", "Credenziali non valide."));
            }

            return Result.Success();
        }
    }
}