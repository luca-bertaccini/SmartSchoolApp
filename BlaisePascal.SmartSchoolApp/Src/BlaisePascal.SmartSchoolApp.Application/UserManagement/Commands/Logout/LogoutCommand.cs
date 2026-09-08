using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlaisePascal.SmartSchoolApp.Application.UserManagement.Commands.Logout
{
    public record LogoutUserCommand(Guid userId) : IRequest<Result>;
}
