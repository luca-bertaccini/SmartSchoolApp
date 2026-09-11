using MediatR;
using System;
using BlaisePascal.SmartSchoolApp.SharedKernel;

namespace BlaisePascal.SmartSchoolApp.Application.UserManagement.Commands.AuthenticateUser
{
    public sealed record AuthenticateUserCommand() : IRequest<Result<Guid>>;
}
