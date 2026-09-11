using MediatR;
using System;
using BlaisePascal.SmartSchoolApp.SharedKernel;

namespace BlaisePascal.SmartSchoolApp.Application.AnalyticsAndReporting.Commands.ExportReport
{
    public sealed record ExportReportCommand() : IRequest<Result<Guid>>;
}
