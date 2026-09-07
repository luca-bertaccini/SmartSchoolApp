using BlaisePascal.SmartSchoolApp.SharedKernel;
using Domain.MonitoringAndAlerts.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlaisePascal.SmartSchoolApp.Domain.MonitoringAndAlerts.Events
{
    public sealed class DeviceAnomalyDetected : IDomainEvent
    {
        public Guid DeviceId { get; }
        public string AnomalyType { get; }
        public DateTime OccurredOnUtc { get; init; }
        public DeviceAnomalyDetected(Guid deviceId, string anomalyType)
        {
            DeviceId = deviceId;
            AnomalyType = anomalyType;
        }
    }
}
