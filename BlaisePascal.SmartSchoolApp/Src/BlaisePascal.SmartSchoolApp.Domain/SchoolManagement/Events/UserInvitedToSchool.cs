using BlaisePascal.SmartSchoolApp.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlaisePascal.SmartSchoolApp.Domain.SchoolManagement.Events
{
    public sealed class UserInvitedToSchool : IDomainEvent
    {
        public Guid SchoolId { get; }
        public Guid UserId { get; }
        public DateTime OccurredOnUtc { get; init; }
        public UserInvitedToSchool(Guid schoolId, Guid userId)
        {
            SchoolId = schoolId;
            UserId = userId;
        }
    }
}
