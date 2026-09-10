using MediatR;
using System;

namespace BlaisePascal.SmartSchoolApp.Application.AnalyticsAndReporting.Commands.ExportReport
{
    public sealed record ExportReportCommand() : IRequest<Result<Guid>>;
}
