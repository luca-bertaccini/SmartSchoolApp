using MediatR;
using System;
using BlaisePascal.SmartSchoolApp.SharedKernel;

namespace BlaisePascal.SmartSchoolApp.Application.AnalyticsAndReporting.Commands.GenerateReport
{
    public sealed record GenerateReportCommand() : IRequest<Result<Guid>>;
}
