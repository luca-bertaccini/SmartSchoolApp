using System;
using Domain.ValueObject;

namespace Domain.AnalyticsAndReporting
{
    public class Report
    {
        public Guid ReportId { get; private set; }
        public Guid SchoolId { get; private set; }
        public TimePeriod Period { get; private set; }
        public Metrics Metrics { get; private set; }
        public DateTime GeneratedAt { get; private set; }

        private Report() { }

        public Report(Guid schoolId, TimePeriod period, Metrics metrics, DateTime generatedAt)
        {
            ReportId = Guid.NewGuid();
            SchoolId = schoolId;
            Period = period;
            Metrics = metrics;
            GeneratedAt = generatedAt;
        }
    }
}
