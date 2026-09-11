using MediatR;
using System;
using BlaisePascal.SmartSchoolApp.SharedKernel;

namespace BlaisePascal.SmartSchoolApp.Application.UserManagement.Commands.LogoutUser
{
    public sealed record LogoutUserCommand() : IRequest<Result<Guid>>;
}
