using System;

namespace Domain.MonitoringAndAlerts
{
    public class ConsumptionRecord
    {
        public Guid RecordId { get; private set; }
        public Guid DeviceId { get; private set; }
        public DateTime Timestamp { get; private set; }
        public double EnergyConsumed { get; private set; }

        private ConsumptionRecord() { }

        public ConsumptionRecord(Guid deviceId, DateTime timestamp, double energyConsumed)
        {
            RecordId = Guid.NewGuid();
            DeviceId = deviceId;
            Timestamp = timestamp;
            EnergyConsumed = energyConsumed;
        }
    }
}
