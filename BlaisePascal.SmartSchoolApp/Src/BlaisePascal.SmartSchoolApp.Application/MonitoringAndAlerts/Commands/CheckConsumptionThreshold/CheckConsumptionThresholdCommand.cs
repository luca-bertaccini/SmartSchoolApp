using MediatR;
using System;
using BlaisePascal.SmartSchoolApp.SharedKernel;

namespace BlaisePascal.SmartSchoolApp.Application.MonitoringAndAlerts.Commands.CheckConsumptionThreshold
{
    public sealed record CheckConsumptionThresholdCommand() : IRequest<Result<Guid>>;
}
