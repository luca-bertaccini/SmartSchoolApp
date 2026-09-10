using MediatR;
using System;

namespace BlaisePascal.SmartSchoolApp.Application.AnalyticsAndReporting.Commands.GenerateReport
{
    public sealed record GenerateReportCommand() : IRequest<Result<Guid>>;
}
