using MediatR;
using System;
using BlaisePascal.SmartSchoolApp.SharedKernel;

namespace BlaisePascal.SmartSchoolApp.Application.MonitoringAndAlerts.Commands.GenerateAlert
{
    public sealed record GenerateAlertCommand() : IRequest<Result<Guid>>;
}
