using BlaisePascal.SmartSchoolApp.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlaisePascal.SmartSchoolApp.Domain.DeviceManagement.Events
{
    public sealed class DeviceTurnedOff : IDomainEvent
    {
        public Guid ReportId { get; }
        public DateTime OccurredOnUtc { get; init; }
        public DeviceTurnedOff(Guid reportId)
        {
            ReportId = reportId;
        }
    }
}
