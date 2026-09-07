using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlaisePascal.SmartSchoolApp.SharedKernel
{
    public record Error
    {
        public static readonly Error None = new(string.Empty, string.Empty, IErrorType.Failure);
        public static readonly Error NullValue = new("General.Null", "Null value was provided", IErrorType.Failure);

        public Error(string code, string description, IErrorType type)
        {
            Code = code;
            Description = description;
            Type = type;
        }

        public string Code { get; }

        public string Description { get; }

        public IErrorType Type { get; }

        public static Error Failure(string code, string description) => new(code, description, IErrorType.Failure);

        public static Error NotFound(string code, string description) => new(code, description, IErrorType.NotFound);

        public static Error Problem(string code, string description) => new(code, description, IErrorType.Problem);

        public static Error Conflict(string code, string description) => new(code, description, IErrorType.Conflict);
    }
}
