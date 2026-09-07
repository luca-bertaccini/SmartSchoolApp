using BlaisePascal.SmartSchoolApp.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlaisePascal.SmartSchoolApp.Domain.SchoolManagement.Events
{
    public sealed class SchoolOwnershipTransferred : IDomainEvent
    {
        public Guid SchoolId { get; }
        public Guid NewOwnerId { get; }
        public DateTime OccurredOnUtc { get; init; }
        public SchoolOwnershipTransferred(Guid schoolId, Guid newOwnerId)
        {
            SchoolId = schoolId;
            NewOwnerId = newOwnerId;
        }
    }
}
