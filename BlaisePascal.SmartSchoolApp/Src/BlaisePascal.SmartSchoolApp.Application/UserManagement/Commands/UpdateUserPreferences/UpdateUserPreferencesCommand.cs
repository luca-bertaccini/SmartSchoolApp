using MediatR;
using System;

namespace BlaisePascal.SmartSchoolApp.Application.UserManagement.Commands.UpdateUserPreferences
{
    public sealed record UpdateUserPreferencesCommand() : IRequest<Result<Guid>>;
}
