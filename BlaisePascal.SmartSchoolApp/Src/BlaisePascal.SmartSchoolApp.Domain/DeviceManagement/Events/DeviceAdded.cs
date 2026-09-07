using BlaisePascal.SmartSchoolApp.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlaisePascal.SmartSchoolApp.Domain.DeviceManagement.Events
{
    public sealed class DeviceAdded : IDomainEvent
    {
        public Guid ReportId { get; }
        public Guid SchoolId { get; }
        public DateTime OccurredOnUtc { get; init; }
        public DeviceAdded(Guid reportId, Guid schoolId)
        {
            ReportId = reportId;
            SchoolId = schoolId;
        }
    }
}
