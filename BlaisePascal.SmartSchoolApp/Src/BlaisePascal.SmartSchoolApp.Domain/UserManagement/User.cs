using BlaisePascal.SmartSchoolApp.Domain.UserManagement;
using BlaisePascal.SmartSchoolApp.Domain.UserManagement.Repository; 
using BlaisePascal.SmartSchoolApp.SharedKernel;
using Domain.ValueObject; 
using System;

namespace Domain.UserManagement
{
    public class User
    {
        public Guid UserId { get; private set; }
        public Email Email { get; private set; }
        public ZoneTime TimeZone { get; private set; }
        public Locale State { get; private set; }
        public PasswordHash PasswordHash { get; private set; }
        public bool IsActive { get; set; }

        public User(ZoneTime timeZone, Email email, Locale state, PasswordHash passwordHash)
        {
            UserId = Guid.NewGuid();
            TimeZone = timeZone;
            Email = email;
            State = state;
            PasswordHash = passwordHash;
            IsActive = true;
        }

        public Result VerifyPassword(string password, IPasswordHasher hasher) 
        {
            var verifyResult = hasher.Verify(password, this.PasswordHash.Value);
            if (verifyResult.IsFailure)
            {
                return Result.Failure(UserErrors.InvalidCredentials);
            }

            return Result.Success();
        }

        public Result UpdatePreferences(ZoneTime newZoneTime, Locale newLocale)
        {
            if (IsActive!)
               return Result.Failure(UserErrors.Inactive);
            TimeZone = newZoneTime;
            State = newLocale;

            return Result.Success();
        }

        public Result Logout()
        {
            if (!IsActive)
            {
                return Result.Failure(UserErrors.Inactive);
            }

            return Result.Success();
        }
    }
}