using MediatR;
using System;

namespace BlaisePascal.SmartSchoolApp.Application.UserManagement.Commands.AuthenticateUser
{
    public sealed record AuthenticateUserCommand() : IRequest<Result<Guid>>;
}
