using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BlaisePascal.SmartSchoolApp.Application.MonitoringAndAlerts.Commands.RecordConsumption
{
    public sealed class RecordConsumptionCommandHandler : IRequestHandler<RecordConsumptionCommand, Result<Guid>>
    {
        public RecordConsumptionCommandHandler()
        {
        }

        public Task<Result<Guid>> Handle(RecordConsumptionCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(Result<Guid>.Failure(Error.None)); // Scaffold implementation
        }
    }
}
