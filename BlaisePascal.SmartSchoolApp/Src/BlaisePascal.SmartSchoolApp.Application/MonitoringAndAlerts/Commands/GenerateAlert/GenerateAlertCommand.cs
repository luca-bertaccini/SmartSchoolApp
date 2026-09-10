using MediatR;
using System;

namespace BlaisePascal.SmartSchoolApp.Application.MonitoringAndAlerts.Commands.GenerateAlert
{
    public sealed record GenerateAlertCommand() : IRequest<Result<Guid>>;
}
