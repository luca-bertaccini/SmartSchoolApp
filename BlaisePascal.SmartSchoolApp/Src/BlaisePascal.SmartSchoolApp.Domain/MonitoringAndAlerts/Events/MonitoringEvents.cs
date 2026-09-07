using System;
using BlaisePascal.SmartSchoolApp.SharedKernel;

namespace Domain.MonitoringAndAlerts.Events
{
    public record ConsumptionRecorded(Guid RecordId, Guid DeviceId) : IDomainEvent;
    public record ConsumptionThresholdExceeded(Guid DeviceId, double ThresholdValue) : IDomainEvent;
    public record DeviceOverUsageDetected(Guid DeviceId) : IDomainEvent;
    public record DeviceAnomalyDetected(Guid DeviceId, string AnomalyType) : IDomainEvent;
    public record AlertAcknowledged(Guid AlertId) : IDomainEvent;
}
