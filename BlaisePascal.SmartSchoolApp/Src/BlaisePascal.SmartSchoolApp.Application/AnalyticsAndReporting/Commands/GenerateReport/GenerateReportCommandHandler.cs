using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using BlaisePascal.SmartSchoolApp.SharedKernel;

namespace BlaisePascal.SmartSchoolApp.Application.AnalyticsAndReporting.Commands.GenerateReport
{
    public sealed class GenerateReportCommandHandler : IRequestHandler<GenerateReportCommand, Result<Guid>>
    {
        public GenerateReportCommandHandler()
        {
        }

        public Task<Result<Guid>> Handle(GenerateReportCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(Result<Guid>.Failure(Error.None)); 
        }
    }
}
