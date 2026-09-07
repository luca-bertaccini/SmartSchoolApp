using BlaisePascal.SmartSchoolApp.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlaisePascal.SmartSchoolApp.Domain.DeviceManagement.Events
{
    public sealed class DeviceTurnedOn : IDomainEvent
    {
        public Guid ReportId { get; }
        public DateTime OccurredOnUtc { get; init; }
        public DeviceTurnedOn(Guid reportId)
        {
            ReportId = reportId;
        }
    }
}
