using MediatR;
using System;
using BlaisePascal.SmartSchoolApp.SharedKernel;

namespace BlaisePascal.SmartSchoolApp.Application.MonitoringAndAlerts.Commands.AcknowledgeAlert
{
    public sealed record AcknowledgeAlertCommand() : IRequest<Result<Guid>>;
}
