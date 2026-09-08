using BlaisePascal.SmartSchoolApp.SharedKernel;

namespace BlaisePascal.SmartSchoolApp.Domain.UserManagement
{
    public record UserErrors : Error
    {
        public static readonly Error InvalidCredentials = new("User.InvalidCredentials", "Invalid email or password.", ErrorType.Conflict);
        public static readonly Error Inactive = new("User.Inactive", "Cannot perform operations on an inactive user.", ErrorType.Conflict);
        public static readonly Error DuplicateEmail = new("User.DuplicateEmail", "The provided email address is already registered.", ErrorType.Conflict);
        public static readonly Error NotFound = new("User.NotFound", "The specified user was not found.", ErrorType.NotFound);
        public static readonly Error PasswordNullOrEmpty = new("User.PasswordNullOrEmpty", "The specified password was not found.", ErrorType.NotFound);
        public static readonly Error PasswordOutOfLenght = new("User.PasswordNullOrEmpty", "The Password Has to be beetween 8 and 16 figures", ErrorType.NotFound);

        public UserErrors(string code, string description, ErrorType type) : base(code, description, type)
        {
        }
    }
}