using MediatR;
using System;
using BlaisePascal.SmartSchoolApp.SharedKernel;

namespace BlaisePascal.SmartSchoolApp.Application.UserManagement.Commands.UpdateUserPreferences
{
    public sealed record UpdateUserPreferencesCommand() : IRequest<Result<Guid>>;
}
