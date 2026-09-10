using MediatR;
using System;

namespace BlaisePascal.SmartSchoolApp.Application.MonitoringAndAlerts.Commands.RecordConsumption
{
    public sealed record RecordConsumptionCommand() : IRequest<Result<Guid>>;
}
