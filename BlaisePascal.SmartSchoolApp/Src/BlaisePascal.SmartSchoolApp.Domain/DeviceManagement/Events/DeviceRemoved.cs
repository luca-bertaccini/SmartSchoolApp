using BlaisePascal.SmartSchoolApp.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlaisePascal.SmartSchoolApp.Domain.DeviceManagement.Events
{
    public sealed class DeviceRemoved : IDomainEvent
    {
        public Guid ReportId { get; }
        public DateTime OccurredOnUtc { get; init; }
        public DeviceRemoved(Guid reportId)
        {
            ReportId = reportId;
        }
    }
}
