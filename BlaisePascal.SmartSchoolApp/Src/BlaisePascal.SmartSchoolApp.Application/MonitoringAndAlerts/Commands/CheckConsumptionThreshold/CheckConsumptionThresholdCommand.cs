using MediatR;
using System;

namespace BlaisePascal.SmartSchoolApp.Application.MonitoringAndAlerts.Commands.CheckConsumptionThreshold
{
    public sealed record CheckConsumptionThresholdCommand() : IRequest<Result<Guid>>;
}
