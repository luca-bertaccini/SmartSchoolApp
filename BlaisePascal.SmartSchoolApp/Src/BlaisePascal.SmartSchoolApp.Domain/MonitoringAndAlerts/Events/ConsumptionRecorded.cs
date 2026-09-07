using BlaisePascal.SmartSchoolApp.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlaisePascal.SmartSchoolApp.Domain.MonitoringAndAlerts.Events
{
    public sealed class ConsumptionRecorded : IDomainEvent
    {
        public Guid RecordId { get; }
        public Guid DeviceId { get; }
        public DateTime OccurredOnUtc { get; init; }
        public ConsumptionRecorded(Guid recordId, Guid deviceId)
        {
            RecordId = recordId;
            DeviceId = deviceId;
        }
    }
}
