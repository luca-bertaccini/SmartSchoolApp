using BlaisePascal.SmartSchoolApp.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlaisePascal.SmartSchoolApp.Domain.MonitoringAndAlerts.Events
{
    public sealed class ConsumptionThresholdExceeded : IDomainEvent
    {
        public Guid RecordId { get; }
        public double ThresholdValue { get; }
        public DateTime OccurredOnUtc { get; init; }
        public ConsumptionThresholdExceeded(Guid recordId, double thresholdValue)
        {
            RecordId = recordId;
            ThresholdValue = thresholdValue;
        }
    }
}
