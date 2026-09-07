using BlaisePascal.SmartSchoolApp.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlaisePascal.SmartSchoolApp.Domain.AnalyticsAndReporting.Events
{
    public sealed class ReportExported : IDomainEvent
    {
        public Guid ReportId { get; }
        public DateTime OccurredOnUtc { get; init; }
        public ReportExported(Guid reportId)
        {
            ReportId = reportId;
        }
    }
}
