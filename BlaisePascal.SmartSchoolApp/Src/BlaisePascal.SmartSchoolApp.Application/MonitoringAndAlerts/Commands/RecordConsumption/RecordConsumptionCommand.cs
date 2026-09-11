using MediatR;
using System;
using BlaisePascal.SmartSchoolApp.SharedKernel;

namespace BlaisePascal.SmartSchoolApp.Application.MonitoringAndAlerts.Commands.RecordConsumption
{
    public sealed record RecordConsumptionCommand() : IRequest<Result<Guid>>;
}
