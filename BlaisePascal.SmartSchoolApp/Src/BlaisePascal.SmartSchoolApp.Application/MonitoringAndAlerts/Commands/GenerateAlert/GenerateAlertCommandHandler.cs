using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using BlaisePascal.SmartSchoolApp.SharedKernel;

namespace BlaisePascal.SmartSchoolApp.Application.MonitoringAndAlerts.Commands.GenerateAlert
{
    public sealed class GenerateAlertCommandHandler : IRequestHandler<GenerateAlertCommand, Result<Guid>>
    {
        public GenerateAlertCommandHandler()
        {
        }

        public Task<Result<Guid>> Handle(GenerateAlertCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(Result<Guid>.Failure(Error.None)); 
        }
    }
}
