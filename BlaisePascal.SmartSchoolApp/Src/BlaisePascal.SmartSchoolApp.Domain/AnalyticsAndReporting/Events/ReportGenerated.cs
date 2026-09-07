using BlaisePascal.SmartSchoolApp.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlaisePascal.SmartSchoolApp.Domain.AnalyticsAndReporting.Events
{
    public sealed class ReportGenerated : IDomainEvent
    {
        public Guid ReportId { get; }
        public Guid SchoolId { get; }
        public DateTime OccurredOnUtc { get; init; }
        public ReportGenerated(Guid reportId, Guid schoolId)
        {
            ReportId = reportId;
            SchoolId = schoolId;
        }
    }
}
