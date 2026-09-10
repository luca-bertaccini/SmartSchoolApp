using MediatR;
using System;

namespace BlaisePascal.SmartSchoolApp.Application.UserManagement.Commands.LogoutUser
{
    public sealed record LogoutUserCommand() : IRequest<Result<Guid>>;
}
