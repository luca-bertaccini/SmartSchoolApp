using BlaisePascal.SmartSchoolApp.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlaisePascal.SmartSchoolApp.Domain.MonitoringAndAlerts.Events
{
    public sealed class AlertAcknowledged : IDomainEvent
    {
        public Guid AlertId { get; }
        public DateTime OccurredOnUtc { get; init; }
        public AlertAcknowledged(Guid alertId)
        {
            AlertId = alertId;
        }
    }
}
