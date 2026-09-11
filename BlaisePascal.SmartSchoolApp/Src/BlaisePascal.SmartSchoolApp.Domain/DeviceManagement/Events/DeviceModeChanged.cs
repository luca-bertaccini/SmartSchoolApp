using BlaisePascal.SmartSchoolApp.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlaisePascal.SmartSchoolApp.Domain.DeviceManagement.Events
{
    public sealed class DeviceModeChanged : IDomainEvent
    {
        public Guid ReportId { get; }
        public string NewMode { get; }
        public DateTime OccurredOnUtc { get; init; }
        public DeviceModeChanged(Guid reportId, string newMode)
        {
            ReportId = reportId;
            NewMode = newMode;
        }
    }
}
