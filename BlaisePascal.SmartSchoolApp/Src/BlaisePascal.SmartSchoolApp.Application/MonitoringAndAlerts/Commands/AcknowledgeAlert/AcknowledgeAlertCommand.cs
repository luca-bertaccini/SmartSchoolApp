using MediatR;
using System;

namespace BlaisePascal.SmartSchoolApp.Application.MonitoringAndAlerts.Commands.AcknowledgeAlert
{
    public sealed record AcknowledgeAlertCommand() : IRequest<Result<Guid>>;
}
