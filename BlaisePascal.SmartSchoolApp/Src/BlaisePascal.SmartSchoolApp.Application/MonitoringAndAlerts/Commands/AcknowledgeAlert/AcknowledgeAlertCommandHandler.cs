using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BlaisePascal.SmartSchoolApp.Application.MonitoringAndAlerts.Commands.AcknowledgeAlert
{
    public sealed class AcknowledgeAlertCommandHandler : IRequestHandler<AcknowledgeAlertCommand, Result<Guid>>
    {
        public AcknowledgeAlertCommandHandler()
        {
        }

        public Task<Result<Guid>> Handle(AcknowledgeAlertCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(Result<Guid>.Failure(Error.None)); // Scaffold implementation
        }
    }
}
