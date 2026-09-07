using BlaisePascal.SmartSchoolApp.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlaisePascal.SmartSchoolApp.Domain.DeviceManagement.Events
{
    public sealed class DeviceUpdated : IDomainEvent
    {
        public Guid ReportId { get; }
        public DateTime OccurredOnUtc { get; init; }
        public DeviceUpdated(Guid reportId)
        {
            ReportId = reportId;
        }
    }
}
