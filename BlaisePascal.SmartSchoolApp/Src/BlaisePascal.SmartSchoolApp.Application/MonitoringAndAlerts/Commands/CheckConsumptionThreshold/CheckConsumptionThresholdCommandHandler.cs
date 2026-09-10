using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BlaisePascal.SmartSchoolApp.Application.MonitoringAndAlerts.Commands.CheckConsumptionThreshold
{
    public sealed class CheckConsumptionThresholdCommandHandler : IRequestHandler<CheckConsumptionThresholdCommand, Result<Guid>>
    {
        public CheckConsumptionThresholdCommandHandler()
        {
        }

        public Task<Result<Guid>> Handle(CheckConsumptionThresholdCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(Result<Guid>.Failure(Error.None)); // Scaffold implementation
        }
    }
}
