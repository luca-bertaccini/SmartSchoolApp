using BlaisePascal.SmartSchoolApp.Domain.UserManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ValueObject
{
    public record PasswordHash
    {
        public string Value { get; private set; }
        private const int MinLength = 8;
        private const int MaxLength = 16;

        private PasswordHash(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                 Result.Failure(UserErrors.PasswordNullOrEmpty);
            if (value.Length < MinLength || value.Length > MaxLength)
                Result.Failure(UserErrors.PasswordOutOfLenght);

            Value = value;
        }
        public static PasswordHash Create(string hash) => new(hash);
    }
}
