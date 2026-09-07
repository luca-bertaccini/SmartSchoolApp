using BlaisePascal.SmartSchoolApp.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlaisePascal.SmartSchoolApp.Domain.MonitoringAndAlerts.Events
{
    public sealed class DeviceOverUsageDetected : IDomainEvent
    {
        public Guid DeviceId { get; }
        public DateTime OccurredOnUtc { get; init; }
        public DeviceOverUsageDetected(Guid deviceId)
        {
            DeviceId = deviceId;
        }
    }
}
