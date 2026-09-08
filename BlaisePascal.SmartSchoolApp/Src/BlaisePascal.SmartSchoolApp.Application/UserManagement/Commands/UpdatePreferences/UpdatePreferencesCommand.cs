using Domain.ValueObject;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlaisePascal.SmartSchoolApp.Application.UserManagement.Commands.UpdatePreferences
{
    public sealed record UpdatePreferencesCommand(Locale locale , ZoneTime zoneTime , Guid userId) : IRequest<Result<Guid>>;
}
