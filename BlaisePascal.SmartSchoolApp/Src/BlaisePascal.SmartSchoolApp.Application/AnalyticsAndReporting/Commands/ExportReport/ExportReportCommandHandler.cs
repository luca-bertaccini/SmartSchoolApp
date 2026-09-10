using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BlaisePascal.SmartSchoolApp.Application.AnalyticsAndReporting.Commands.ExportReport
{
    public sealed class ExportReportCommandHandler : IRequestHandler<ExportReportCommand, Result<Guid>>
    {
        public ExportReportCommandHandler()
        {
        }

        public Task<Result<Guid>> Handle(ExportReportCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(Result<Guid>.Failure(Error.None)); // Scaffold implementation
        }
    }
}
