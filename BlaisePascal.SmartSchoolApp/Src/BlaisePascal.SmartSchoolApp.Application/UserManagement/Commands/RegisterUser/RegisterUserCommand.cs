using MediatR;
using System;
using BlaisePascal.SmartSchoolApp.SharedKernel;

namespace BlaisePascal.SmartSchoolApp.Application.UserManagement.Commands.RegisterUser
{
    public sealed record RegisterUserCommand() : IRequest<Result<Guid>>;
}
