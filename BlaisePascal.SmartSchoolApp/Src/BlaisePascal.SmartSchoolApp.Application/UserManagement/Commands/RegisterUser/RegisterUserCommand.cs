using BlaisePascal.SmartSchoolApp.SharedKernel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlaisePascal.SmartSchoolApp.Application.UserManagement.Commands.RegisterUser
{
    public sealed record RegisterUserCommand(
    string Email,
    string PlainPassword,
    string Timezone,
    string Locale
) : IRequest<Result<Guid>>;
}