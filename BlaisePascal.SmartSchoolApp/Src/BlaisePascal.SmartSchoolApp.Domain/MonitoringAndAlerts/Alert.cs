using System;
using Domain.ValueObject;

namespace Domain.MonitoringAndAlerts
{
    public class Alert
    {
        public Guid AlertId { get; private set; }
        public AlertType Type { get; private set; }
        public string Message { get; private set; }
        public Guid DeviceId { get; private set; }
        public Guid SchoolId { get; private set; }
        public DateTime Timestamp { get; private set; }
        public string Status { get; private set; }

        private Alert() { }

        public Alert(AlertType type, string message, Guid deviceId, Guid schoolId, DateTime timestamp, string status)
        {
            AlertId = Guid.NewGuid();
            Type = type;
            Message = message;
            DeviceId = deviceId;
            SchoolId = schoolId;
            Timestamp = timestamp;
            Status = status;
        }

        public void Acknowledge()
        {
            Status = "Acknowledged";
        }
    }
}
