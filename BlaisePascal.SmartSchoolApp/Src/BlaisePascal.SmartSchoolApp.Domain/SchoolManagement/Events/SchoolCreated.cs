using BlaisePascal.SmartSchoolApp.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlaisePascal.SmartSchoolApp.Domain.SchoolManagement.Events
{
    public sealed class SchoolCreated : IDomainEvent
    {
        public Guid SchoolId { get; }
        public DateTime OccurredOnUtc { get; init; }
        public SchoolCreated(Guid schoolId)
        {
            SchoolId = schoolId;
        }
    }
}
