using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlaisePascal.SmartSchoolApp.Application.UserManagement.Commands.VerifyPassword
{
    public sealed record VerifyPasswordCommand(string password, Guid userId) : IRequest<Result<Guid>>;
}
